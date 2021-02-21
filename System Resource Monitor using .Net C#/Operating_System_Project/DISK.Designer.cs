namespace Operating_System_Project
{
    partial class DISK
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pDisk = new System.Diagnostics.PerformanceCounter();
            this.lblDisk = new System.Windows.Forms.Label();
            this.progressBarDisk = new System.Windows.Forms.ProgressBar();
            this.chartDisk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisk)).BeginInit();
            this.SuspendLayout();
            // 
            // pDisk
            // 
            this.pDisk.CategoryName = "PhysicalDisk";
            this.pDisk.CounterName = "% Disk Time";
            this.pDisk.InstanceName = "_Total";
            // 
            // lblDisk
            // 
            this.lblDisk.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisk.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDisk.Location = new System.Drawing.Point(947, 136);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(87, 48);
            this.lblDisk.TabIndex = 9;
            this.lblDisk.Text = "0 MB";
            this.lblDisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarDisk
            // 
            this.progressBarDisk.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBarDisk.Location = new System.Drawing.Point(567, 146);
            this.progressBarDisk.Name = "progressBarDisk";
            this.progressBarDisk.Size = new System.Drawing.Size(359, 37);
            this.progressBarDisk.TabIndex = 8;
            this.progressBarDisk.Click += new System.EventHandler(this.progressBarDisk_Click);
            // 
            // chartDisk
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDisk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDisk.Legends.Add(legend1);
            this.chartDisk.Location = new System.Drawing.Point(514, 197);
            this.chartDisk.Name = "chartDisk";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Disk";
            this.chartDisk.Series.Add(series1);
            this.chartDisk.Size = new System.Drawing.Size(524, 284);
            this.chartDisk.TabIndex = 7;
            this.chartDisk.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(60, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 329);
            this.listBox1.TabIndex = 10;
            // 
            // DISK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 512);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDisk);
            this.Controls.Add(this.progressBarDisk);
            this.Controls.Add(this.chartDisk);
            this.Name = "DISK";
            this.Text = "DISK";
            this.Load += new System.EventHandler(this.DISK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pDisk;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.ProgressBar progressBarDisk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDisk;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox listBox1;
    }
}