namespace AHP_App.Form
{
    partial class FrmKriteria
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
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnMatrixBobot = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(8, 51);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(303, 200);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dtGridView_UserDeletingRow);
            this.dtGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtGridView_UserDeletedRow);
            this.dtGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellClick);
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.Location = new System.Drawing.Point(236, 257);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 1;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnMatrixBobot
            // 
            this.btnMatrixBobot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMatrixBobot.Location = new System.Drawing.Point(8, 257);
            this.btnMatrixBobot.Name = "btnMatrixBobot";
            this.btnMatrixBobot.Size = new System.Drawing.Size(75, 23);
            this.btnMatrixBobot.TabIndex = 5;
            this.btnMatrixBobot.Text = "Matrix Bobot";
            this.btnMatrixBobot.UseVisualStyleBackColor = true;
            this.btnMatrixBobot.Click += new System.EventHandler(this.btnMatrixBobot_Click);
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNama.Location = new System.Drawing.Point(12, 25);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(218, 20);
            this.txtNama.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Location = new System.Drawing.Point(236, 22);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FrmKriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 292);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnMatrixBobot);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.dtGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKriteria";
            this.Text = "Kriteria";
            this.Load += new System.EventHandler(this.FrmKriteria_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKriteria_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnMatrixBobot;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
    }
}