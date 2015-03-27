namespace AHP_App.Form
{
    partial class FrmMatrixBobot
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.cmbKriteria = new System.Windows.Forms.ComboBox();
            this.lblKriteria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Location = new System.Drawing.Point(620, 370);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.Location = new System.Drawing.Point(701, 370);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 2;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToResizeRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(12, 36);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersVisible = false;
            this.dtGridView.Size = new System.Drawing.Size(764, 328);
            this.dtGridView.TabIndex = 3;
            this.dtGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellValueChanged);
            // 
            // cmbKriteria
            // 
            this.cmbKriteria.FormattingEnabled = true;
            this.cmbKriteria.Location = new System.Drawing.Point(57, 9);
            this.cmbKriteria.Name = "cmbKriteria";
            this.cmbKriteria.Size = new System.Drawing.Size(157, 21);
            this.cmbKriteria.TabIndex = 4;
            this.cmbKriteria.SelectedIndexChanged += new System.EventHandler(this.cmbKriteria_SelectedIndexChanged);
            // 
            // lblKriteria
            // 
            this.lblKriteria.AutoSize = true;
            this.lblKriteria.Location = new System.Drawing.Point(12, 12);
            this.lblKriteria.Name = "lblKriteria";
            this.lblKriteria.Size = new System.Drawing.Size(39, 13);
            this.lblKriteria.TabIndex = 5;
            this.lblKriteria.Text = "Kriteria";
            // 
            // FrmMatrixBobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 401);
            this.Controls.Add(this.lblKriteria);
            this.Controls.Add(this.cmbKriteria);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnSimpan);
            this.MaximizeBox = false;
            this.Name = "FrmMatrixBobot";
            this.Text = "Form Matrix Bobot - ###";
            this.Load += new System.EventHandler(this.FrmMatrixBobot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label lblKriteria;
    }
}