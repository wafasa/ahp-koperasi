//#define RELEASE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using helper.Class;


namespace AHP_App.Form
{
    public partial class FrmLogin : System.Windows.Forms.Form
    {
        readonly ClassDbConnect _dbConnect = new ClassDbConnect();

        public FrmLogin()
        {
            InitializeComponent();
#if(RELEASE)
            txtPassword.Clear();
            txtUserID.Clear();
#endif

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var i = _dbConnect.intExecuteScalar(
                string.Format("SELECT COUNT(*) " +
                              "FROM user " +
                              "WHERE nama='{0}' AND password='{1}'"
                              , txtUserID.Text, txtPassword.Text));

            if (i != 0)
            {
                var frmMain = new FrmMain();
                frmMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Nama atau Password Salah!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
