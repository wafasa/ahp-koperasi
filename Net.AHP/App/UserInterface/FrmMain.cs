using System;
using System.Globalization;
using System.Windows.Forms;
using AHP_App.Form;
using DotNetMatrix;
using Lib.AHP;
using helper.Class;

namespace AHP_App
{
    public partial class FrmMain : System.Windows.Forms.Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kriteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormLoader.LoadFormType(typeof(FrmKriteria), this);
            //var frmKriteria = new FrmKriteria { MdiParent = this };
            //frmKriteria.Show();
        }

        private void kriteriaItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormLoader.LoadFormType(typeof(FrmKriteriaItems), this);
            //var frmKriteriaItems = new FrmKriteriaItems { MdiParent = this };
            //frmKriteriaItems.Show();
        }

        private void anggotaKoperasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormLoader.LoadFormType(typeof(FrmAnggotaKoperasi), this);
            //var frmAnggotaKoperasi = new FrmAnggotaKoperasi { MdiParent = this };
            //frmAnggotaKoperasi.Show();
        }

        private void prosessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO:cek apakah ada windows lain yang terbuka.
            //     jika ada maka sarankan ke user agar menutup semua windows yang terbuka
            MdiFormLoader.LoadFormType(typeof(FrmProcess), this);
        }

        private void triasfahrudingmailcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[][] criteria = new double[][]
								{ 
									new double[] {1,2,3},
									new double[] {0,1,1.5},
									new double[] {0,0,1}
								};
            //double[][] xxx = new double[2][];

            double[][] kecantikanChoices = new double[][]
				{
					new double[] {1,4,3},
					new double[] {0,1,0.5},
					new double[] {0,0,1}
				};

            double[][] pendidikanChoices = new double[][]
				{
					new double[] {1,0.33,0.25},
					new double[] {0,1,0.5},
					new double[] {0,0,1}
				};

            double[][] kekayaanChoices = new double[][]
				{
					new double[] {1,0.01,0.10},
					new double[] {0,1,10},
					new double[] {0,0,1}
				};

            //4 criteria, 3 choices
            AHPModel model = new AHPModel(3, 3);
            model.AddCriteria(criteria);
            model.AddCriterionRatedChoices(0, kecantikanChoices);
            model.AddCriterionRatedChoices(1, pendidikanChoices);
            model.AddCriterionRatedChoices(2, kekayaanChoices);
           

            model.CalculateModel();



            GeneralMatrix calcCriteria = model.CalculatedCriteria;
            GeneralMatrix results = model.ModelResult;
            GeneralMatrix choices = model.CalculatedChoices;

            //results.ge

            //choices: SF 42%, Orlando31%, NY 27%
            //Assert.AreEqual(31, System.Math.Round(choices.GetElement(0, 0) * 100, 0));
            //Assert.AreEqual(42, System.Math.Round(choices.GetElement(1, 0) * 100, 0));
            //Assert.AreEqual(27, System.Math.Round(choices.GetElement(2, 0) * 100, 0));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
