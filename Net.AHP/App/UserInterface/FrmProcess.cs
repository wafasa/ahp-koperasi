using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DotNetMatrix;
using Lib.AHP;
using helper.Class;


namespace AHP_App.Form
{
    public partial class FrmProcess : System.Windows.Forms.Form
    {
        public FrmProcess()
        {
            InitializeComponent();
        }

        readonly ClassDbConnect _dbConnect = new ClassDbConnect();
        private const double CiAcceptableValue = 0.1;
        private double[][] _criteria;


        private void InsertLog(string str)
        {
            log.Text += string.Format("{0}\n", str);
        }

        private bool CalculatePcm(double[][] matrix)
        {
            //insertLog("\nENTER FUNC()=> private bool calculatePCM(...)");

            PrioritiesSelector ps = new PrioritiesSelector();
            GeneralMatrix oldMatrix = new GeneralMatrix(matrix);
            //for all transposed elements calculate their inverse values
            GeneralMatrix newMatrix = AHPModel.ExpandUtility(oldMatrix);
            ps.ComputePriorities(newMatrix);
            //System.Math.Round(choices.GetElement(0, 0) * 100, 0))
            InsertLog(string.Format("Consistency Ratio: {0}%", System.Math.Round(ps.ConsistencyRatio * 100, 0)));
            //if(ps.ConsistencyRatio == double.NaN)
            return ps.ConsistencyRatio <= CiAcceptableValue;
        }

        private bool CalculatePcmCriteria()
        {
            //insertLog("\nENTER FUNC()=> private bool calculatePCM_Criteria(...)");

            var dt = _dbConnect.GetRecord(string.Format("SELECT kode " +
                                                        "FROM tbl_kriteria " +
                                                        "WHERE aktif='{0}' " +
                                                        "ORDER BY kode", "True"));

            _criteria = new double[dt.Rows.Count][];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _criteria[i] = new double[dt.Rows.Count];
                double kodeA = double.Parse(dt.Rows[i][0].ToString());

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    double kodeB = double.Parse(dt.Rows[j][0].ToString());
                    double a = _dbConnect.doubleExecuteScalar(string.Format("SELECT nilai " +
                                                                            "FROM tbl_kriteria_bobot " +
                                                                            "WHERE kode_a={0} AND kode_b={1}", kodeA, kodeB));

                    _criteria[i][j] = a;
                    //log.Text += string.Format("kode_a = {0} - kode_b={1} = {2}\n", kode_a, kode_b, a);
                }
            }
            return CalculatePcm(_criteria);
        }

        private double GetNilaiKriteriaItem(int kodeA, int kodeB)
        {
            double a =
                _dbConnect.doubleExecuteScalar(
                    string.Format("SELECT nilai " +
                    "FROM tbl_kriteria_items_bobot " +
                    "WHERE kode_a={0} AND kode_b={1}", kodeA, kodeB));

            double nilai = a;

            if (a == 0)
            {
                double b =
                _dbConnect.doubleExecuteScalar(
                    string.Format("SELECT nilai " +
                    "FROM tbl_kriteria_items_bobot " +
                    "WHERE kode_a={0} AND kode_b={1}", kodeB, kodeA));
                nilai = 1 / b;
            }

            return nilai;
        }

        private void FrmProcessLoad(object sender, EventArgs e)
        {
            //insertLog("\nENTER FUNC()=> private void FrmProcess_Load(...)");
            //_____START CALCULATING AHP
            log.Clear();
            log.Text += "[START] Kalkulasi Kriteria...";

            if (CalculatePcmCriteria())
            {
                InsertLog("[OK] Nilai Consistency Ratio dapat diterima\n");
            }
            else
            {
                InsertLog("[ERROR] Nilai Consistency Ratio tidak dapat diterima\n" +
                          "Proses tidak dapat dilanjutkan");
                // ReSharper disable RedundantJumpStatement
                return;
                // ReSharper restore RedundantJumpStatement
            }

            InsertLog("\n[START] Kalkulasi kandidat...");

            var dt = _dbConnect.GetRecord(string.Format("SELECT kode,nama " +
                                                        "FROM tbl_kriteria " +
                                                        "WHERE aktif='{0}' " +
                                                        "ORDER BY kode", "True"));

            int countCandidate = _dbConnect.intExecuteScalar("SELECT COUNT(*) " +
                                                             "FROM tbl_anggota");

            //inisialisasi AHP model
            AHPModel model = new AHPModel(dt.Rows.Count, countCandidate);
            //add kriteria
            model.AddCriteria(_criteria);


            //untuk masing-masing kriteria..
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int kodeKriteria = int.Parse(dt.Rows[i][0].ToString());

                var dtA = _dbConnect.GetRecord(string.Format("SELECT kode_kriteria_item " +
                                                             "FROM tbl_anggota_kriteria_items " +
                                                             "WHERE kode_kriteria={0} " +
                                                             "ORDER BY kode_anggota", kodeKriteria));

                double[][] arrayKandidatBobot = new double[dtA.Rows.Count][];
                //kalkulasikan nilai dari matrix kriteria anggota
                for (int k = 0; k < dtA.Rows.Count; k++)
                {
                    arrayKandidatBobot[k] = new double[dtA.Rows.Count];
                    int kodeA = int.Parse(dtA.Rows[k][0].ToString());

                    for (int l = 0; l < dtA.Rows.Count; l++)
                    {
                        if (k == l)
                        {
                            //nilai = 1
                            arrayKandidatBobot[k][l] = 1;
                        }
                        else if (k > l)
                        {
                            //nilai 0
                            arrayKandidatBobot[k][l] = 0;
                        }
                        else
                        {
                            int kodeB = int.Parse(dtA.Rows[l][0].ToString());
                            arrayKandidatBobot[k][l] = GetNilaiKriteriaItem(kodeA, kodeB);
                        }
                    }
                }


                if (dtA.Rows.Count <= 2)
                {
                    InsertLog("Kandidat <= dari 2, maka tidak perlu dilakukan pengecekan Consistency Index(CI)");
                }
                else
                {
                    //periksa apakah Pair Comparation matrix untuk kriteria ini punya CI <= CI_acceptableValue ?
                    if (CalculatePcm(arrayKandidatBobot))
                    {
                        InsertLog(string.Format("[OK] Nilai Consistency Ratio untuk {0} dapat diterima\n", dt.Rows[i][1]));
                    }
                    else
                    {
                        InsertLog("[ERROR] Nilai Consistency Ratio tidak dapat diterima\n" +
                                  "Proses tidak dapat dilanjutkan");
                        // ReSharper disable RedundantJumpStatement
                        return;
                        // ReSharper restore RedundantJumpStatement
                    }
                }

                model.AddCriterionRatedChoices(i, arrayKandidatBobot);
            }

            model.CalculateModel();
            GeneralMatrix calcCriteria = model.CalculatedCriteria;
            GeneralMatrix results = model.ModelResult;
            GeneralMatrix choices = model.CalculatedChoices;

            //choices: SF 42%, Orlando31%, NY 27%
            //Assert.AreEqual(31, System.Math.Round(choices.GetElement(0, 0) * 100, 0));
            //Assert.AreEqual(42, System.Math.Round(choices.GetElement(1, 0) * 100, 0));
            //Assert.AreEqual(27, System.Math.Round(choices.GetElement(2, 0) * 100, 0));

            //clear all rows on gridview
            dtGridView.Columns.Clear();
            var dgvColumnKriteria = new DataGridViewTextBoxColumn
                                    {
                                        HeaderText = "Kriteria",
                                        Name = "kriteria",
                                        SortMode = DataGridViewColumnSortMode.NotSortable
                                    };
            int colKriteria = dtGridView.Columns.Add(dgvColumnKriteria);
            dtGridView.Columns[colKriteria].Frozen = true;

            var dgvColumnWeight = new DataGridViewTextBoxColumn
                                      {
                                          HeaderText = "Berat",
                                          Name = "Weight",
                                          SortMode = DataGridViewColumnSortMode.NotSortable
                                      };
            dtGridView.Columns.Add(dgvColumnWeight);

            //            calcCriteria : weight cantik -> kaya
            //            result : choise yayu (cantik -> kaya)
            //                     grace (cantik -> kaya)
            //                     fitri (cantik -> kaya)
            //            choices :Composite Weight (Yayu ->Fitri)  

            //insert candidate name


            var dtKandidat = _dbConnect.GetRecord("SELECT nama " +
                                                  "FROM tbl_anggota " +
                                                  "ORDER BY kode");

            for (int a = 0; a < dtKandidat.Rows.Count; a++)
            {
                var dgvColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = dtKandidat.Rows[a][0].ToString(),
                    Name = string.Format("kandidat-{0}", a),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dtGridView.Columns.Add(dgvColumn);
            }

            var dtKriteria = _dbConnect.GetRecord("SELECT nama " +
                                                  "FROM tbl_kriteria " +
                                                  "ORDER BY kode");

            //string[] chartSeriesArray = new string[dtKriteria.Rows.Count];


            chart1.Series.Clear();
            chart1.ChartAreas[0].BackColor = Color.LightBlue;
            chart1.ChartAreas[0].BackSecondaryColor = Color.White;
            chart1.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;
            chart1.ChartAreas[0].BorderColor = Color.Black;
            chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[0].BorderWidth = 1;
            chart1.ChartAreas[0].ShadowOffset = 4;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            //chart1.ChartAreas[0].Area3DStyle.Inclination = 90;
            //chart1.ChartAreas[0].Area3DStyle.Rotation = 45;
            chart1.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Simplistic;

            chart1.Legends[0].BackColor = Color.LightBlue;
            chart1.Legends[0].BackSecondaryColor = Color.White;
            chart1.Legends[0].BackGradientStyle = GradientStyle.DiagonalLeft;
            chart1.Legends[0].BorderColor = Color.Black;
            chart1.Legends[0].BorderWidth = 1;
            chart1.Legends[0].BorderDashStyle = ChartDashStyle.Solid;

            chart1.Legends[0].ShadowOffset = 2;

            for (int i = 0; i < dtKriteria.Rows.Count; i++)
            {
                //add new ros
                dtGridView.Rows.Add(1);
                dtGridView[0, i].Value = dtKriteria.Rows[i][0].ToString();

                string seriesName = dtKriteria.Rows[i][0].ToString();
                this.chart1.Series.Add(seriesName);
                //gunakan ini untuk swith axis -> chart1.Series[seriesName].ChartType = SeriesChartType.Bar;
                chart1.Series[seriesName].ChartType = SeriesChartType.Column;
                chart1.Series[seriesName].BorderWidth = 0;
                chart1.Series[seriesName].ShadowOffset = 3;

                dtGridView[1, i].Value = System.Math.Round(calcCriteria.GetElement(i, 0), 4);

                for (int j = 0; j < dtKandidat.Rows.Count; j++)
                {
                    double val = results.GetElement(j, i);
                    dtGridView[j + 2, i].Value = System.Math.Round(val, 4);

                    string kandidateName = dtKandidat.Rows[j][0].ToString();
                    chart1.Series[seriesName].Points.AddXY(kandidateName,val);
                }
            }

            //composite weight
            dtGridView.Rows.Add(1);
            dtGridView[0, dtGridView.Rows.Count - 1].Value = "Composite Weight";
            for (int b = 0; b < dtKandidat.Rows.Count; b++)
            {
                dtGridView[b + 2, dtGridView.Rows.Count - 1].Value = string.Format("{0}",System.Math.Round(choices.GetElement(b, 0),3), System.Math.Round(choices.GetElement(b, 0) * 100, 0));
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
