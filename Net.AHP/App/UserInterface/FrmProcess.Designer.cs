namespace AHP_App.Form
{
    partial class FrmProcess
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOCW = new System.Windows.Forms.TabPage();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTutup = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageOCW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.tabPageGraph.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageOCW);
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageOCW
            // 
            this.tabPageOCW.Controls.Add(this.dtGridView);
            this.tabPageOCW.Location = new System.Drawing.Point(4, 22);
            this.tabPageOCW.Name = "tabPageOCW";
            this.tabPageOCW.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOCW.Size = new System.Drawing.Size(525, 298);
            this.tabPageOCW.TabIndex = 1;
            this.tabPageOCW.Text = "Perhitungan Hasil";
            this.tabPageOCW.UseVisualStyleBackColor = true;
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridView.Location = new System.Drawing.Point(3, 3);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.Size = new System.Drawing.Size(519, 292);
            this.dtGridView.TabIndex = 0;
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.panel1);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(525, 298);
            this.tabPageGraph.TabIndex = 0;
            this.tabPageGraph.Text = "Chart";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 292);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(519, 292);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.Location = new System.Drawing.Point(463, 483);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 1;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(12, 342);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(529, 135);
            this.log.TabIndex = 2;
            this.log.Text = "";
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 518);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmProcess";
            this.Text = "FrmProcess";
            this.Load += new System.EventHandler(this.FrmProcessLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOCW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.tabPageGraph.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.TabPage tabPageOCW;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dtGridView;
    }
}