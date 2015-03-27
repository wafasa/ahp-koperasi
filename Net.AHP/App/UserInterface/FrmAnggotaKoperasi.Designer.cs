namespace AHP_App.Form
{
    partial class FrmAnggotaKoperasi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnKriteria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnBaru);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.txtTelp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatal.Location = new System.Drawing.Point(252, 176);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 22;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaru.Location = new System.Drawing.Point(94, 176);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBaru.TabIndex = 21;
            this.btnBaru.Text = "Data Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(333, 176);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 20;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtTelp
            // 
            this.txtTelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelp.Location = new System.Drawing.Point(92, 141);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(191, 20);
            this.txtTelp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "No.Telp";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlamat.Location = new System.Drawing.Point(92, 50);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(316, 77);
            this.txtAlamat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.Location = new System.Drawing.Point(92, 19);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(316, 20);
            this.txtNama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(12, 225);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(458, 194);
            this.dtGridView.TabIndex = 1;
            this.dtGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dtGridView_UserDeletingRow);
            this.dtGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtGridView_UserDeletedRow);
            this.dtGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellClick);
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(393, 425);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 25);
            this.btnTutup.TabIndex = 11;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.BtnTutupClick);
            // 
            // btnKriteria
            // 
            this.btnKriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKriteria.Location = new System.Drawing.Point(12, 427);
            this.btnKriteria.Name = "btnKriteria";
            this.btnKriteria.Size = new System.Drawing.Size(100, 23);
            this.btnKriteria.TabIndex = 12;
            this.btnKriteria.Text = "Detail Anggota ";
            this.btnKriteria.UseVisualStyleBackColor = true;
            this.btnKriteria.Click += new System.EventHandler(this.btnKriteria_Click);
            // 
            // FrmAnggotaKoperasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 458);
            this.Controls.Add(this.btnKriteria);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnggotaKoperasi";
            this.Text = "Form Anggota Koperasi";
            this.Load += new System.EventHandler(this.FrmAnggotaKoperasi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnKriteria;
    }
}