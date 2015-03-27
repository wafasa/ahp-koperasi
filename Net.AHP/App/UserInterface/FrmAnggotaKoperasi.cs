using System;
using System.Windows.Forms;
using helper.Class;

namespace AHP_App.Form
{
    public partial class FrmAnggotaKoperasi : System.Windows.Forms.Form
    {

        readonly ClassDbConnect _dbConnect = new ClassDbConnect();
        private int _selectedkode = -1;

        public FrmAnggotaKoperasi()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            ClassHelper.ClearTextBox(this);
            var dataTable = _dbConnect.GetRecord(
                "SELECT kode," +
                "       nama as Nama," +
                "       alamat as Alamat," +
                "       telp as Telp " +
                "FROM tbl_anggota " +
                "ORDER BY kode");
            dtGridView.DataSource = dataTable;
            //dtGridView.Columns[0].Visible = false;
        }

        private void SetEnabledOnBtn(bool btnNewEnable, bool btnCancelEnable, bool btnSaveEnable)
        {
            btnBaru.Enabled = btnNewEnable;
            btnBatal.Enabled = btnCancelEnable;
            btnSimpan.Enabled = btnSaveEnable;
            ClassHelper.SetReadOnlyOnTextBox(this, btnNewEnable);
        }

        private void FrmAnggotaKoperasi_Load(object sender, EventArgs e)
        {
            LoadData();
            SetEnabledOnBtn(true, false, false);

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap!");
                return;
            }


            if (_selectedkode != -1)
            {//update data

                var q =
                    string.Format(
                        "UPDATE tbl_anggota " +
                        "SET nama = '{0}', " +
                        "    alamat = '{1}', " +
                        "    telp = '{2}' " +
                        "WHERE kode = {3}",
                        txtNama.Text, txtAlamat.Text,
                        txtTelp.Text, _selectedkode);
                _dbConnect.ExecuteNonQuery(q);

            }
            else
            {//new data

                var q = string.Format(
                    "INSERT INTO tbl_anggota(nama,alamat,telp) " +
                    "VALUES('{0}','{1}','{2}')",
                    txtNama.Text, txtAlamat.Text,
                    txtTelp.Text);
                //MessageBox.Show(q);
                _dbConnect.ExecuteNonQuery(q);
            }

            _selectedkode = -1; //set to "-1" agar disign sebagai databaru

            ClassHelper.ClearTextBox(this);
            SetEnabledOnBtn(true, false, false);
            LoadData();
        }

        private void dtGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) !=
                DialogResult.Yes) return;
            if (dtGridView.SelectedRows.Count <= 0) return;

            var kode = dtGridView[0, dtGridView.SelectedRows[0].Index].Value.ToString();
            //delete dosen
            var q = string.Format("DELETE FROM tbl_anggota " +
                                  "WHERE kode = ('{0}')", kode);
            _dbConnect.ExecuteNonQuery(q);

            //delete pengampu
            var q_1 = string.Format("DELETE FROM tbl_anggota_kriteria_items " +
                                    "WHERE kode_anggota = ('{0}')", kode);
            _dbConnect.ExecuteNonQuery(q_1);

        }

        private void dtGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            LoadData();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            ClassHelper.ClearTextBox(this);
            SetEnabledOnBtn(false, true, true);
            _selectedkode = -1;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClassHelper.ClearTextBox(this);
            SetEnabledOnBtn(true, false, false);
        }

        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetEnabledOnBtn(false, true, true);

            _selectedkode = int.Parse(dtGridView[0, dtGridView.SelectedRows[0].Index].Value.ToString());
            
            txtNama.Text = dtGridView[1, dtGridView.SelectedRows[0].Index].Value.ToString();
            txtAlamat.Text = dtGridView[2, dtGridView.SelectedRows[0].Index].Value.ToString();
            txtTelp.Text = dtGridView[3, dtGridView.SelectedRows[0].Index].Value.ToString();
        }

        private void BtnTutupClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKriteria_Click(object sender, EventArgs e)
        {
            //
            FrmMatrixBobot frm = new FrmMatrixBobot(Constants.KRITERIA_ANGGOTA_BOBOT);
            frm.ShowDialog();
        }
    }
}
