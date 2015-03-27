using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using helper.Class;

namespace AHP_App.Form
{
    public partial class FrmMatrixBobot : System.Windows.Forms.Form
    {
        private readonly int _forWhat;
        readonly ClassDbConnect _dbConnect = new ClassDbConnect();
        //private bool cellValChange;
        //private bool FormLoaded;
        //private int currCmbKriteriaSelectedIndex;

        public FrmMatrixBobot(int forWhat)
        {
            InitializeComponent();
            this._forWhat = forWhat;
        }

        private void loadKriteriaData()
        {
            var a = string.Format("SELECT kode,nama " +
                                  "FROM tbl_kriteria " +
                                  "WHERE aktif='{0}' " +
                                  "ORDER BY kode", "True");
            var dtTable = _dbConnect.GetRecord(a);
            cmbKriteria.DataSource = dtTable;
            cmbKriteria.DisplayMember = "nama";
            cmbKriteria.ValueMember = "kode";
        }


        private int KodeKriteria()
        {
            var row_kodeKriteria = ((DataTable)cmbKriteria.DataSource).Rows[cmbKriteria.SelectedIndex];
            return (int)row_kodeKriteria["kode"];
        }


        private void setGridView(string query)
        {
            dtGridView.Columns.Clear();

            var dtTable = _dbConnect.GetRecord(query);


            //__________________________________________________create collumns
            var dgvColumnDummy = new DataGridViewTextBoxColumn
            {
                HeaderText = "...",
                Name = "Kolom_Dummy"
            };

            int colDummy = dtGridView.Columns.Add(dgvColumnDummy);
            dtGridView.Columns[colDummy].Frozen = true;


            for (var i = 0; i < dtTable.Rows.Count; i++)
            {

                var dgvColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = dtTable.Rows[i][0].ToString(),
                    Name = string.Format("Kolom-{0}", i.ToString(CultureInfo.InvariantCulture))
                };


                dtGridView.Columns.Add(dgvColumn);
                dtGridView.Rows.Add(1);
                dtGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dtGridView[0, i].Value = dtTable.Rows[i][0].ToString();

            }


            for (int j = 1; j < dtGridView.Columns.Count; j++)
            {


                for (int i = 0; i < dtGridView.Rows.Count; i++)
                {
                    if (j == i + 1)
                    {
                        //_________diagonal values always 1
                        dtGridView[j, i].Style.BackColor = SystemColors.Control;
                        dtGridView[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dtGridView[j, i].Value = 1;
                        dtGridView[j, i].ReadOnly = true;
                    }
                    else if (j <= i)
                    {

                        dtGridView[j, i].Style.BackColor = Color.Lavender;
                        dtGridView[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dtGridView[j, i].Value = 0;
                        dtGridView[j, i].ReadOnly = true;
                    }
                    else
                    {
                        switch (this._forWhat)
                        {
                            case 1:
                                int kodeB = KodeKriteria(dtGridView.Columns[j].HeaderText);
                                int kodeA = KodeKriteria(dtGridView[0, i].Value.ToString());

                                //int count = _dbConnect.intExecuteScalar("")
                                double a = _dbConnect.doubleExecuteScalar(
                                    string.Format("SELECT IF(COUNT(nilai) = 0,0,nilai) " +
                                                  "FROM tbl_kriteria_bobot " +
                                                  "WHERE kode_a = {0} AND kode_b={1}",
                                                  kodeA, kodeB));
                                dtGridView[j, i].Value = a;
                                dtGridView[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;
                            case 2:
                                int kodeB_kriteriaItem = KodeKriteriaItems(KodeKriteria(),
                                                                           dtGridView.Columns[j].HeaderText);
                                int kodeA_kriteriaItem = KodeKriteriaItems(KodeKriteria(),
                                                                           dtGridView[0, i].Value.ToString());

                                double a_kriteriaItem = _dbConnect.doubleExecuteScalar(
                                    string.Format("SELECT IF(COUNT(nilai) = 0,0,nilai) " +
                                                  "FROM tbl_kriteria_items_bobot " +
                                                  "WHERE kode_a = {0} AND kode_b={1}",
                                                  kodeA_kriteriaItem, kodeB_kriteriaItem));
                                dtGridView[j, i].Value = a_kriteriaItem;
                                dtGridView[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;

                        }
                    }
                }
            }


            //dtGridView[1, 0].Style.BackColor = Color.Blue;
            //dtGridView[6, 5].Style.BackColor = Color.Blue;

            dtGridView.Columns[0].ReadOnly = true;
            this.dtGridView.EnableHeadersVisualStyles = false;
            //set color header
            this.dtGridView.Columns[0].DefaultCellStyle.BackColor = SystemColors.Control;

        }


        private int KodeKriteria(string kriteriaName)
        {
            return _dbConnect.intExecuteScalar(string.Format("SELECT kode " +
                                                              "FROM tbl_kriteria " +
                                                              "WHERE nama='{0}'", kriteriaName));


        }

        private int KodeKriteriaItems(int kodeKriteria, string kriteriaItemName)
        {
            return _dbConnect.intExecuteScalar(string.Format("SELECT kode " +
                                                              "FROM tbl_kriteria_items " +
                                                              "WHERE kode_kriteria={0} AND nama='{1}'",
                                                              kodeKriteria, kriteriaItemName));

        }

        private void FrmMatrixBobot_Load(object sender, EventArgs e)
        {

            cmbKriteria.Enabled = false;
            lblKriteria.Enabled = false;

            switch (this._forWhat)
            {
                case 1:
                    //KRITERIA_BOBOT

                    this.Text = "Form Matrix Bobot - Bobot Kriteria ";

                    var a = string.Format("SELECT nama " +
                                          "FROM tbl_kriteria " +
                                          "WHERE aktif = '{0}' " +
                                          "ORDER BY kode", "True");

                    setGridView(a);

                    break;
                case 2:
                    //KRITERIA_ITEMS_BOBOT
                    loadKriteriaData();
                    //FormLoaded = true;
                    cmbKriteria.Enabled = true;
                    lblKriteria.Enabled = true;
                    //loadKriteriaItemsBobot();
                    break;
                case 3:
                    //KRITERIA_ANGGOTA_BOBOT
                    //loadKriteriaData();
                    dtGridView.Columns.Clear();

                    this.Text = "Form Data Details Anggota";

                    var b = string.Format("SELECT nama,kode " +
                                          "FROM tbl_kriteria " +
                                          "WHERE aktif = '{0}' " +
                                          "ORDER BY kode", "True");
                    var dtTable = _dbConnect.GetRecord(b);

                    var dgvColumnKode = new DataGridViewTextBoxColumn
                                            {
                                                HeaderText = "Kode",
                                                Name = "kode"
                                            };
                    dtGridView.Columns.Add(dgvColumnKode);
                    dtGridView.Columns[0].Visible = false;

                    var dgvColumnNama = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Nama",
                        Name = "nama"
                    };
                    dtGridView.Columns.Add(dgvColumnNama);
                    dtGridView.Columns[1].ReadOnly = true;

                    for (var i = 0; i < dtTable.Rows.Count; i++)
                    {

                        var dgvColumn = new DataGridViewComboBoxColumn
                        {
                            HeaderText = dtTable.Rows[i][0].ToString(),
                            Name = string.Format("Kolom-{0}", i.ToString(CultureInfo.InvariantCulture))
                        };


                        var dt = _dbConnect.GetRecord(string.Format(
                                                    "SELECT kode,nama " +
                                                    "FROM tbl_kriteria_items " +
                                                    "WHERE kode_kriteria = {0} " +
                                                    "ORDER BY kode", int.Parse(dtTable.Rows[i][1].ToString())));

                        //dgvColumn.DataSource = dt;
                        //dgvColumn.DisplayMember = "nama";
                        //dgvColumn.ValueMember = "kode";

                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            dgvColumn.Items.Add(dt.Rows[j][1].ToString());
                        }

                        dtGridView.Columns.Add(dgvColumn);
                        //dtGridView.Rows.Add(1);
                        dtGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        //dtGridView[0, i].Value = dtTable.Rows[i][0].ToString();

                    }

                    //get anggota kode and name
                    var dtAnggota = _dbConnect.GetRecord("SELECT kode,nama " +
                                                         "FROM tbl_anggota " +
                                                         "ORDER BY kode");

                    for (int j = 0; j < dtAnggota.Rows.Count; j++)
                    {
                        dtGridView.Rows.Add(1);
                        int kode_anggota = int.Parse(dtAnggota.Rows[j][0].ToString());

                        dtGridView[0, j].Value = kode_anggota.ToString(CultureInfo.InvariantCulture);
                        dtGridView[1, j].Value = dtAnggota.Rows[j][1].ToString();

                        //lets set the value! SEMANGAAAAAAAAAAAAATTTTT
                        for (int i = 2; i < dtGridView.Columns.Count; i++)
                        {
                            string strHeader = dtGridView.Columns[i].HeaderText;
                            //MessageBox.Show(kodeKriteria(strHeader).ToString());
                            var strVal = _dbConnect.strExecuteScalar(
                                string.Format("SELECT b.nama as Nama_Kriteria_Items," +
                                              "       c.nama as Nama_Kriteria " +
                                              "FROM tbl_anggota_kriteria_items a " +
                                              "LEFT JOIN tbl_kriteria_items b " +
                                              "ON a.kode_kriteria_item = b.kode " +
                                              "LEFT JOIN tbl_kriteria c " +
                                              "ON a.kode_kriteria = c.kode " +
                                              "WHERE a.kode_anggota = {0} AND a.kode_kriteria = {1}",
                                              kode_anggota, KodeKriteria(strHeader)));

                            //MessageBox.Show(strVal==null?"NULL":"NOT_NULL");
                            if (strVal != null)
                            {
                                //MessageBox.Show("lala");
                                dtGridView[i, j].Value = strVal;
                            }
                        }
                    }
                    //dtGridView[2, 0].Value = "PNS";
                    //MessageBox.Show(dtGridView.Columns.Count.ToString());
                    //MessageBox.Show(dtGridView.Rows.Count.ToString());
                    break;
            }
        }


        private void cmbKriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KRITERIA_ITEMS_BOBOT

            //if (cellValChange && FormLoaded && this._forWhat == 2)
            //{
            //    if (MessageBox.Show("Data telah berubah. Apakah anda ingin menyimpan perubahan ini?", "Simpan data?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        btnSimpan.PerformClick();
            //    }
            //}

            this.Text = "Form Matrix Bobot - Bobot Kriteria Items";

            var a = string.Format("SELECT nama " +
                                  "FROM tbl_kriteria_items " +
                                  "WHERE kode_kriteria = '{0}' " +
                                  "ORDER BY kode", KodeKriteria());

            setGridView(a);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = false;

            switch (this._forWhat)
            {
                case 1:
                    //1.delete all records from database
                    //2.insert new data
                    //_dbConnect.ExecuteNonQuery("TRUNCATE TABLE tbl_kriteria_bobot");

                    for (int i = 0; i < dtGridView.Rows.Count; i++)
                    {
                        string strHeaderA = dtGridView[0, i].Value.ToString();
                        int kodeKriteriaA = KodeKriteria(strHeaderA);

                        for (int j = 1; j < dtGridView.Columns.Count; j++)
                        {
                            string strHeaderB = dtGridView.Columns[j].HeaderText;
                            int kodeKriteriaB = KodeKriteria(strHeaderB);
                            try
                            {
                                double nilai = double.Parse(dtGridView[j, i].Value.ToString());

                                //delete old data
                                _dbConnect.ExecuteNonQuery(string.Format("DELETE FROM tbl_kriteria_bobot " +
                                                                         "WHERE kode_a={0} AND kode_b={1}", kodeKriteriaA, kodeKriteriaB));

                                //insert new data                                
                                _dbConnect.ExecuteNonQuery(string.Format("INSERT INTO tbl_kriteria_bobot(kode_a,kode_b,nilai) " +
                                                                         "VALUES({0},{1},{2})", kodeKriteriaA, kodeKriteriaB, nilai));
                            }
                            // "aaa".Substring()   
                            catch (Exception)
                            {
                                MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                                //throw;
                            }
                        }
                    }

                    MessageBox.Show("Data telah disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    //MessageBox.Show("triasfahrudin".Substring(0, 2));
                    string strQueryInsert = null;
                    string strQueryDelete = null;
                    for (int c = 0; c < dtGridView.Rows.Count; c++)
                    {
                        string strHeaderA = dtGridView[0, c].Value.ToString();
                        int kodeKriteriaA = KodeKriteriaItems(KodeKriteria(), strHeaderA);

                        for (int d = 1; d < dtGridView.Columns.Count; d++)
                        {
                            string strHeaderB = dtGridView.Columns[d].HeaderText;
                            int kodeKriteriaB = KodeKriteriaItems(KodeKriteria(), strHeaderB);

                            double nilai = double.Parse(dtGridView[d, c].Value.ToString());

                             //delete old data
                            strQueryDelete += string.Format(" (kode_a={0} AND kode_b={1}) OR",kodeKriteriaA,kodeKriteriaB);

                            //insert new data
                            strQueryInsert += string.Format("({0},{1},{2}),", kodeKriteriaA, kodeKriteriaB, nilai);
                        }
                    }
                    
                    _dbConnect.ExecuteNonQuery(string.Format("DELETE FROM tbl_kriteria_items_bobot WHERE {0}",strQueryDelete.Substring(0,strQueryDelete.Length - 2)));

                    _dbConnect.ExecuteNonQuery(string.Format("INSERT INTO tbl_kriteria_items_bobot(kode_a,kode_b,nilai) " +
                                                             "VALUES{0}",strQueryInsert.Substring(0,strQueryInsert.Length - 1)));
                    MessageBox.Show("Data telah disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cellValChange = false;
                    break;
                case 3:
                    //1.delete all records from database
                    //2.insert new data
                    _dbConnect.ExecuteNonQuery("TRUNCATE TABLE tbl_anggota_kriteria_items");

                    for (int i = 0; i < dtGridView.Rows.Count; i++)
                    {
                        for (int j = 2; j < dtGridView.Columns.Count; j++)
                        {

                            string strHeader = dtGridView.Columns[j].HeaderText;
                            int kodeKriteria = KodeKriteria(strHeader);
                            string strIsi = dtGridView[j, i].Value.ToString();

                            var a = string.Format(
                                "INSERT INTO tbl_anggota_kriteria_items(kode_anggota,kode_kriteria,kode_kriteria_item) " +
                                "VALUES({0},{1},{2})",
                                int.Parse(dtGridView[0, i].Value.ToString()),
                                kodeKriteria, KodeKriteriaItems(kodeKriteria, strIsi));

                            //MessageBox.Show(a);
                            _dbConnect.ExecuteNonQuery(a);
                        }
                    }

                    MessageBox.Show("Data telah disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            btnSimpan.Enabled = true;
        }

        private void dtGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //cellValChange = true;
        }
    }
}
