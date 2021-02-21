namespace Operating_System_Project
{
    partial class RAM
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
            this.lblRAM = new System.Windows.Forms.Label();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.chartRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRAM
            // 
            this.lblRAM.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRAM.Location = new System.Drawing.Point(512, 199);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(87, 48);
            this.lblRAM.TabIndex = 6;
            this.lblRAM.Text = "0 MB";
            this.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBarRAM.Location = new System.Drawing.Point(132, 209);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(359, 37);
            this.progressBarRAM.TabIndex = 5;
            // 
            // chartRAM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRAM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRAM.Legends.Add(legend1);
            this.chartRAM.Location = new System.Drawing.Point(81, 270);
            this.chartRAM.Name = "chartRAM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "RAM";
            this.chartRAM.Series.Add(series1);
            this.chartRAM.Size = new System.Drawing.Size(524, 284);
            this.chartRAM.TabIndex = 4;
            this.chartRAM.Text = "chart1";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(192, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Memory Utilization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.chartRAM);
            this.Name = "RAM";
            this.Text = "RAM";
            this.Load += new System.EventHandler(this.RAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}