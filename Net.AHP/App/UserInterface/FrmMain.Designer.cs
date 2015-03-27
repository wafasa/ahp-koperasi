namespace AHP_App
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kriteriaItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.anggotaKoperasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.prosessToolStripMenuItem,
            this.tESTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kriteriaToolStripMenuItem,
            this.kriteriaItemsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.anggotaKoperasiToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // kriteriaToolStripMenuItem
            // 
            this.kriteriaToolStripMenuItem.Name = "kriteriaToolStripMenuItem";
            this.kriteriaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kriteriaToolStripMenuItem.Text = "Kriteria";
            this.kriteriaToolStripMenuItem.Click += new System.EventHandler(this.kriteriaToolStripMenuItem_Click);
            // 
            // kriteriaItemsToolStripMenuItem
            // 
            this.kriteriaItemsToolStripMenuItem.Name = "kriteriaItemsToolStripMenuItem";
            this.kriteriaItemsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kriteriaItemsToolStripMenuItem.Text = "Kriteria Items";
            this.kriteriaItemsToolStripMenuItem.Click += new System.EventHandler(this.kriteriaItemsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // anggotaKoperasiToolStripMenuItem
            // 
            this.anggotaKoperasiToolStripMenuItem.Name = "anggotaKoperasiToolStripMenuItem";
            this.anggotaKoperasiToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.anggotaKoperasiToolStripMenuItem.Text = "Anggota Koperasi";
            this.anggotaKoperasiToolStripMenuItem.Click += new System.EventHandler(this.anggotaKoperasiToolStripMenuItem_Click);
            // 
            // prosessToolStripMenuItem
            // 
            this.prosessToolStripMenuItem.Name = "prosessToolStripMenuItem";
            this.prosessToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.prosessToolStripMenuItem.Text = "Proses";
            this.prosessToolStripMenuItem.Click += new System.EventHandler(this.prosessToolStripMenuItem_Click);
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.tESTToolStripMenuItem.Text = "_TEST_";
            this.tESTToolStripMenuItem.Visible = false;
            this.tESTToolStripMenuItem.Click += new System.EventHandler(this.tESTToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 478);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytic Hierarchy Process v1.0 ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kriteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kriteriaItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anggotaKoperasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
    }
}

