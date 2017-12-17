namespace CHW
{
	partial class Graph
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonCloseGraph = new System.Windows.Forms.Button();
			this.graphTypeBox = new System.Windows.Forms.ListBox();
			this.graphColorBox = new System.Windows.Forms.ListBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart
			// 
			chartArea3.BackColor = System.Drawing.Color.White;
			chartArea3.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart.Legends.Add(legend3);
			this.chart.Location = new System.Drawing.Point(21, 307);
			this.chart.Name = "chart";
			this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			series3.YValuesPerPoint = 5;
			this.chart.Series.Add(series3);
			this.chart.Size = new System.Drawing.Size(3741, 1550);
			this.chart.TabIndex = 0;
			this.chart.Text = "chart";
			// 
			// buttonCloseGraph
			// 
			this.buttonCloseGraph.AutoSize = true;
			this.buttonCloseGraph.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonCloseGraph.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCloseGraph.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonCloseGraph.Location = new System.Drawing.Point(2982, 17);
			this.buttonCloseGraph.Name = "buttonCloseGraph";
			this.buttonCloseGraph.Size = new System.Drawing.Size(780, 221);
			this.buttonCloseGraph.TabIndex = 12;
			this.buttonCloseGraph.Text = "Закрыть!";
			this.buttonCloseGraph.UseVisualStyleBackColor = false;
			this.buttonCloseGraph.Click += new System.EventHandler(this.buttonCloseGraph_Click);
			// 
			// graphTypeBox
			// 
			this.graphTypeBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.graphTypeBox.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.graphTypeBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.graphTypeBox.FormattingEnabled = true;
			this.graphTypeBox.ItemHeight = 106;
			this.graphTypeBox.Location = new System.Drawing.Point(2040, 22);
			this.graphTypeBox.Name = "graphTypeBox";
			this.graphTypeBox.Size = new System.Drawing.Size(819, 216);
			this.graphTypeBox.TabIndex = 13;
			this.graphTypeBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// graphColorBox
			// 
			this.graphColorBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.graphColorBox.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.graphColorBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.graphColorBox.FormattingEnabled = true;
			this.graphColorBox.ItemHeight = 106;
			this.graphColorBox.Location = new System.Drawing.Point(1112, 22);
			this.graphColorBox.Name = "graphColorBox";
			this.graphColorBox.Size = new System.Drawing.Size(819, 216);
			this.graphColorBox.TabIndex = 14;
			this.graphColorBox.SelectedIndexChanged += new System.EventHandler(this.graphColorBox_SelectedIndexChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(45, 1893);
			this.trackBar1.Maximum = 11;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(3691, 114);
			this.trackBar1.TabIndex = 15;
			this.trackBar1.Value = 1;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// Graph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(3808, 2072);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.graphColorBox);
			this.Controls.Add(this.graphTypeBox);
			this.Controls.Add(this.buttonCloseGraph);
			this.Controls.Add(this.chart);
			this.Name = "Graph";
			this.Text = "Graph";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Graph_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.Button buttonCloseGraph;
		private System.Windows.Forms.ListBox graphTypeBox;
		private System.Windows.Forms.ListBox graphColorBox;
		private System.Windows.Forms.TrackBar trackBar1;
	}
}