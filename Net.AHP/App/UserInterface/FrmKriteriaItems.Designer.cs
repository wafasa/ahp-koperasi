namespace AHP_App.Form
{
    partial class FrmKriteriaItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnMatrixBobot = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriteria";
            // 
            // cmbKriteria
            // 
            this.cmbKriteria.FormattingEnabled = true;
            this.cmbKriteria.Location = new System.Drawing.Point(15, 25);
            this.cmbKriteria.Name = "cmbKriteria";
            this.cmbKriteria.Size = new System.Drawing.Size(182, 21);
            this.cmbKriteria.TabIndex = 1;
            this.cmbKriteria.SelectedIndexChanged += new System.EventHandler(this.CmbKriteriaSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Kriteria";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNama.Location = new System.Drawing.Point(205, 25);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(153, 20);
            this.txtNama.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Location = new System.Drawing.Point(364, 25);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.BtnSimpanClick);
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(15, 52);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(424, 216);
            this.dtGridView.TabIndex = 5;
            this.dtGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DtGridViewUserDeletingRow);
            this.dtGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DtGridViewUserDeletedRow);
            // 
            // btnMatrixBobot
            // 
            this.btnMatrixBobot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMatrixBobot.Location = new System.Drawing.Point(12, 274);
            this.btnMatrixBobot.Name = "btnMatrixBobot";
            this.btnMatrixBobot.Size = new System.Drawing.Size(75, 23);
            this.btnMatrixBobot.TabIndex = 7;
            this.btnMatrixBobot.Text = "Matrix Bobot";
            this.btnMatrixBobot.UseVisualStyleBackColor = true;
            this.btnMatrixBobot.Click += new System.EventHandler(this.BtnMatrixBobotClick);
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.Location = new System.Drawing.Point(364, 274);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 6;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.BtnTutupClick);
            // 
            // FrmKriteriaItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 309);
            this.Controls.Add(this.btnMatrixBobot);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKriteria);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmKriteriaItems";
            this.Text = "Form Kriteria Items";
            this.Load += new System.EventHandler(this.FrmKriteriaItemsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnMatrixBobot;
        private System.Windows.Forms.Button btnTutup;
    }
}