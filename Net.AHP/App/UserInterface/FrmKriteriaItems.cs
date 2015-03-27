using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using helper.Class;

namespace AHP_App.Form
{
    public partial class FrmKriteriaItems : System.Windows.Forms.Form
    {
        readonly ClassDbConnect _dbConnect = new ClassDbConnect();
        private int _selectedkode = -1;

        public FrmKriteriaItems()
        {
            InitializeComponent();
        }

        private void LoadKriteriaData()
        {
            var a = string.Format("SELECT kode,nama " +
                                  "FROM tbl_kriteria " +
                                  "WHERE aktif='{0}' " +
                                  "ORDER BY kode","True");
            var dtTable = _dbConnect.GetRecord(a);
            cmbKriteria.DataSource = dtTable;
            cmbKriteria.DisplayMember = "nama";
            cmbKriteria.ValueMember = "kode";
        }


        private int KodeKriteria()
        {
            var rowKodeKriteria = ((DataTable)cmbKriteria.DataSource).Rows[cmbKriteria.SelectedIndex];
            return (int)rowKodeKriteria["kode"];
        }

        private void LoadData()
        {
            var a = string.Format("SELECT kode,kode_kriteria,nama as `Sub Kriteria` " +
                                  "FROM tbl_kriteria_items " +
                                  "WHERE kode_kriteria = {0} " +
                                  "ORDER BY kode",
                                  KodeKriteria());
            var dt = _dbConnect.GetRecord(a);

            dtGridView.DataSource = dt;
            dtGridView.Columns[0].Visible = false;
            dtGridView.Columns[1].Visible = false;
            dtGridView.Columns[2].Width = 300;
        }

        private void FrmKriteriaItemsLoad(object sender, EventArgs e)
        {
            LoadKriteriaData();
            LoadData();
        }

        private void BtnTutupClick(object sender, EventArgs e)
        {
            Close();
        }

        private void DtGridViewUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) !=
              DialogResult.Yes) return;
            if (dtGridView.SelectedRows.Count <= 0) return;

            var kode = int.Parse(dtGridView[0, dtGridView.SelectedRows[0].Index].Value.ToString());

            //delete data from tbl_kriteria_items
            var a = string.Format("DELETE FROM tbl_kriteria_items " +
                                  "WHERE kode = ({0})", kode);
            _dbConnect.ExecuteNonQuery(a);

            //delete data from tbl_kriteria_items_bobot
            var b = string.Format("DELETE FROM tbl_kriteria_items_bobot " +
                                  "WHERE kode_a = {0} OR kode_b = {0}",kode);
            _dbConnect.ExecuteNonQuery(b);

            //delete from tbl_anggota_kriteria_items
            var c = string.Format("DELETE FROM tbl_anggota_kriteria_items " +
                                  "WHERE kode_kriteria_item = {0}",kode);
            _dbConnect.ExecuteNonQuery(c);

        }

        private void DtGridViewUserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //
            LoadData();
        }

        private void BtnSimpanClick(object sender, EventArgs e)
        {
            //cek data
            if (txtNama.Text.Trim() == string.Empty || cmbKriteria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Data Belum Lengkap");
                return;
            }

            //tambahkan data baru ke dtGridView
            //dtGridView.Rows.Add(txtNama.Text, "True");

            //tbl_kriteria
            //kode,nama,aktif

            var a = string.Format("INSERT INTO tbl_kriteria_items(kode_kriteria,nama) " +
                                  "VALUES('{0}','{1}')",KodeKriteria(), txtNama.Text);
            _dbConnect.ExecuteNonQuery(a);


            _selectedkode = -1; //set to "-1" agar disign sebagai databaru
            ClassHelper.ClearTextBox(this);
            LoadData();
        }

        private void CmbKriteriaSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnMatrixBobotClick(object sender, EventArgs e)
        {
            FrmMatrixBobot frm = new FrmMatrixBobot(Constants.KRITERIA_ITEMS_BOBOT);
            frm.ShowDialog();
        }
    }
}
