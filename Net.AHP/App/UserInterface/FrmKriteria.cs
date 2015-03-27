using System;
using System.Windows.Forms;
using helper.Class;

namespace AHP_App.Form
{
    public partial class FrmKriteria : System.Windows.Forms.Form
    {
        readonly ClassDbConnect _dbConnect = new ClassDbConnect();
        private int _selectedkode = -1;


        //create kolom pada dtGridView 
        //kolom : kode,nama dan Aktif
        private void createDBGridColumn()
        {
            //kode,nama,aktif

            //Kode 
            var dgvKode = new DataGridViewTextBoxColumn { HeaderText = "Kode", Name = "dgvKode", ReadOnly = true };
            dtGridView.Columns.Add(dgvKode);

            //Nama 
            var dgvNama = new DataGridViewTextBoxColumn { HeaderText = "Nama", Name = "dgvNama", ReadOnly = true };
            dtGridView.Columns.Add(dgvNama);

            //Aktif
            var dgvAktif = new DataGridViewCheckBoxColumn { HeaderText = "Aktif", Name = "dgvAktif", ReadOnly = false };
            dtGridView.Columns.Add(dgvAktif);
        }

        public FrmKriteria()
        {
            InitializeComponent();
            createDBGridColumn();
        }


        private void loadData()
        {
            ClassHelper.ClearTextBox(this);
            dtGridView.Rows.Clear();

            var dtTable = _dbConnect.GetRecord(
                string.Format(
                "SELECT kode,nama,aktif " +
                "FROM tbl_kriteria " +
                //"WHERE aktif='True' "+                
                "ORDER BY kode")
                );

            //dtGridView.DataSource = dtTable;
            for (var i = 0; i < dtTable.Rows.Count; i++)
            {
                dtGridView.Rows.Add(
                    dtTable.Rows[i][0].ToString(),
                    dtTable.Rows[i][1].ToString(),
                    dtTable.Rows[i][2].ToString()
                    );
            }

            dtGridView.Columns[0].Visible = false;
        }


        private void FrmKriteria_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnMatrixBobot_Click(object sender, EventArgs e)
        {
            //MdiFormLoader.LoadFormType(typeof(FrmMatrixBobot), this.ParentForm);
            FrmMatrixBobot frm = new FrmMatrixBobot(Constants.KRITERIA_BOBOT);
            frm.ShowDialog();
        }

        private void updateAktif()
        {
            for (int i = 0; i < dtGridView.Rows.Count; i++)
            {
                string str = dtGridView[2, i].Value.ToString() == "True" ? "True" : "False";

                var a = string.Format("UPDATE tbl_kriteria SET aktif = '{0}' WHERE kode = {1}", str,
                                      int.Parse(dtGridView[0, i].Value.ToString()));
                _dbConnect.ExecuteNonQuery(a);

            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dtGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) !=
               DialogResult.Yes) return;
            if (dtGridView.SelectedRows.Count <= 0) return;

            var kode = int.Parse(dtGridView[0, dtGridView.SelectedRows[0].Index].Value.ToString());

            var a = string.Format("DELETE FROM tbl_kriteria where kode = ({0})", kode);
            _dbConnect.ExecuteNonQuery(a);

            //delete data from tbl_kriteria_bobot
            var b = string.Format("DELETE FROM tbl_kriteria_bobot " +
                                  "WHERE kode_a = {0} OR kode_b={0}", kode);
            _dbConnect.ExecuteNonQuery(b);

            //delete tbl_kriteria_items_bobot first!
            var c = string.Format("SELECT kode FROM tbl_kriteria_items WHERE kode_kriteria ={0}", kode);
            var dtTableC = _dbConnect.GetRecord(c);
            for (var i = 0; i < dtTableC.Rows.Count; i++)
            {
                var f = string.Format("DELETE FROM tbl_kriteria_items_bobot WHERE kode_a={0} OR kode_b={0}", dtTableC.Rows[i][0], dtTableC.Rows[i][0]);
                _dbConnect.ExecuteNonQuery(f);
            }

            //delete data from tbl_kriteria_items
            var d = string.Format("DELETE FROM tbl_kriteria_items " +
                                  "WHERE kode_kriteria = {0}", kode);
            _dbConnect.ExecuteNonQuery(d);


            //delete data tbl_anggota_kriteria_items
            var g = string.Format("DELETE FROM tbl_anggota_kriteria_items " +
                                  "WHERE kode_kriteria = {0}", kode);
            _dbConnect.ExecuteNonQuery(g);
        }

        private void dtGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            loadData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //cek data
            if (txtNama.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Data Belum Lengkap");
                return;
            }

            //tambahkan data baru ke dtGridView
            //dtGridView.Rows.Add(txtNama.Text, "True");

            //tbl_kriteria
            //kode,nama,aktif

            if(_selectedkode != -1)
            {
                //update data
                var a = string.Format(
                   "UPDATE tbl_kriteria " +
                   "SET nama='{0}' " +
                   "WHERE kode={1} "
                   , txtNama.Text, _selectedkode);
                _dbConnect.ExecuteNonQuery(a);

            }else
            {
                //insert data
                var a = string.Format("INSERT INTO tbl_kriteria(nama,aktif) " +
                                  "VALUES('{0}','{1}')", txtNama.Text, "True");
                _dbConnect.ExecuteNonQuery(a);
            }

            _selectedkode = -1; //set to "-1" agar disign sebagai databaru
            ClassHelper.ClearTextBox(this);
            loadData();
        }

        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedkode = int.Parse(dtGridView[0, dtGridView.SelectedRows[0].Index].Value.ToString());
            txtNama.Text = dtGridView[1, dtGridView.SelectedRows[0].Index].Value.ToString();
        }

       
        private void FrmKriteria_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateAktif();
        }


    }
}
