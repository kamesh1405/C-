namespace Operating_System_Project
{
    partial class NETWORK
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lblREC = new System.Windows.Forms.Label();
            this.progressBarRec = new System.Windows.Forms.ProgressBar();
            this.chartNetwork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pNetworkRec = new System.Diagnostics.PerformanceCounter();
            this.pNetworkSent = new System.Diagnostics.PerformanceCounter();
            this.progressBarSent = new System.Windows.Forms.ProgressBar();
            this.lblSent = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNetworkRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNetworkSent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bandwidth Utilization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblREC
            // 
            this.lblREC.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREC.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblREC.Location = new System.Drawing.Point(460, 94);
            this.lblREC.Name = "lblREC";
            this.lblREC.Size = new System.Drawing.Size(87, 48);
            this.lblREC.TabIndex = 10;
            this.lblREC.Text = "Bytes Recieved/sec";
            this.lblREC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarRec
            // 
            this.progressBarRec.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBarRec.Location = new System.Drawing.Point(80, 105);
            this.progressBarRec.Name = "progressBarRec";
            this.progressBarRec.Size = new System.Drawing.Size(359, 37);
            this.progressBarRec.TabIndex = 9;
            // 
            // chartNetwork
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNetwork.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNetwork.Legends.Add(legend1);
            this.chartNetwork.Location = new System.Drawing.Point(23, 232);
            this.chartNetwork.Name = "chartNetwork";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "REC";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Sent";
            this.chartNetwork.Series.Add(series1);
            this.chartNetwork.Series.Add(series2);
            this.chartNetwork.Size = new System.Drawing.Size(524, 272);
            this.chartNetwork.TabIndex = 8;
            this.chartNetwork.Text = "chart1";
            // 
            // pNetworkRec
            // 
            this.pNetworkRec.CategoryName = "Network Interface";
            this.pNetworkRec.CounterName = "Bytes Received/sec";
            this.pNetworkRec.InstanceName = "Instance";
            // 
            // pNetworkSent
            // 
            this.pNetworkSent.CategoryName = "Network Interface";
            this.pNetworkSent.CounterName = "Bytes Sent/sec";
            this.pNetworkSent.InstanceName = "Instance";
            // 
            // progressBarSent
            // 
            this.progressBarSent.ForeColor = System.Drawing.Color.SeaGreen;
            this.progressBarSent.Location = new System.Drawing.Point(80, 168);
            this.progressBarSent.Name = "progressBarSent";
            this.progressBarSent.Size = new System.Drawing.Size(359, 37);
            this.progressBarSent.TabIndex = 12;
            // 
            // lblSent
            // 
            this.lblSent.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSent.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSent.Location = new System.Drawing.Point(457, 148);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(87, 48);
            this.lblSent.TabIndex = 13;
            this.lblSent.Text = "Bytes Sent/sec";
            this.lblSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(150, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 48);
            this.label2.TabIndex = 14;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(425, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 48);
            this.label3.TabIndex = 15;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NETWORK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSent);
            this.Controls.Add(this.progressBarSent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblREC);
            this.Controls.Add(this.progressBarRec);
            this.Controls.Add(this.chartNetwork);
            this.Name = "NETWORK";
            this.Text = "NETWORK";
            this.Load += new System.EventHandler(this.NETWORK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNetworkRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNetworkSent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblREC;
        private System.Windows.Forms.ProgressBar progressBarRec;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNetwork;
        private System.Diagnostics.PerformanceCounter pNetworkRec;
        private System.Diagnostics.PerformanceCounter pNetworkSent;
        private System.Windows.Forms.ProgressBar progressBarSent;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}