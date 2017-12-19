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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonCloseGraph = new System.Windows.Forms.Button();
			this.graphTypeBox = new System.Windows.Forms.ListBox();
			this.graphColorBox = new System.Windows.Forms.ListBox();
			this.trackBarMin = new System.Windows.Forms.TrackBar();
			this.trackBarMax = new System.Windows.Forms.TrackBar();
			this.buttonColorDialog = new System.Windows.Forms.Button();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.buttonExport = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).BeginInit();
			this.SuspendLayout();
			// 
			// chart
			// 
			chartArea1.BackColor = System.Drawing.Color.White;
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(21, 307);
			this.chart.Name = "chart";
			this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series1.YValuesPerPoint = 5;
			this.chart.Series.Add(series1);
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
			this.buttonCloseGraph.Location = new System.Drawing.Point(3258, 17);
			this.buttonCloseGraph.Name = "buttonCloseGraph";
			this.buttonCloseGraph.Size = new System.Drawing.Size(504, 221);
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
			this.graphTypeBox.Location = new System.Drawing.Point(2681, 22);
			this.graphTypeBox.Name = "graphTypeBox";
			this.graphTypeBox.Size = new System.Drawing.Size(504, 216);
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
			this.graphColorBox.Location = new System.Drawing.Point(1413, 22);
			this.graphColorBox.Name = "graphColorBox";
			this.graphColorBox.Size = new System.Drawing.Size(504, 216);
			this.graphColorBox.TabIndex = 14;
			this.graphColorBox.SelectedIndexChanged += new System.EventHandler(this.graphColorBox_SelectedIndexChanged);
			// 
			// trackBarMin
			// 
			this.trackBarMin.Location = new System.Drawing.Point(45, 1893);
			this.trackBarMin.Maximum = 100;
			this.trackBarMin.Minimum = 1;
			this.trackBarMin.Name = "trackBarMin";
			this.trackBarMin.Size = new System.Drawing.Size(1800, 114);
			this.trackBarMin.TabIndex = 15;
			this.trackBarMin.Value = 50;
			this.trackBarMin.ValueChanged += new System.EventHandler(this.trackBarMin_ValueChanged);
			// 
			// trackBarMax
			// 
			this.trackBarMax.Location = new System.Drawing.Point(1962, 1893);
			this.trackBarMax.Maximum = 100;
			this.trackBarMax.Minimum = 1;
			this.trackBarMax.Name = "trackBarMax";
			this.trackBarMax.Size = new System.Drawing.Size(1800, 114);
			this.trackBarMax.TabIndex = 16;
			this.trackBarMax.Value = 50;
			this.trackBarMax.ValueChanged += new System.EventHandler(this.trackBarMax_ValueChanged);
			// 
			// buttonColorDialog
			// 
			this.buttonColorDialog.AutoSize = true;
			this.buttonColorDialog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonColorDialog.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonColorDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonColorDialog.Location = new System.Drawing.Point(2062, 17);
			this.buttonColorDialog.Name = "buttonColorDialog";
			this.buttonColorDialog.Size = new System.Drawing.Size(518, 221);
			this.buttonColorDialog.TabIndex = 17;
			this.buttonColorDialog.Text = "Еще цветов!";
			this.buttonColorDialog.UseVisualStyleBackColor = false;
			this.buttonColorDialog.Click += new System.EventHandler(this.buttonColorDialog_Click);
			// 
			// buttonExport
			// 
			this.buttonExport.AutoSize = true;
			this.buttonExport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonExport.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonExport.Location = new System.Drawing.Point(499, 22);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(721, 221);
			this.buttonExport.TabIndex = 18;
			this.buttonExport.Text = "Экспоритровать!";
			this.buttonExport.UseVisualStyleBackColor = false;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// Graph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(3808, 2072);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonColorDialog);
			this.Controls.Add(this.trackBarMax);
			this.Controls.Add(this.trackBarMin);
			this.Controls.Add(this.graphColorBox);
			this.Controls.Add(this.graphTypeBox);
			this.Controls.Add(this.buttonCloseGraph);
			this.Controls.Add(this.chart);
			this.Name = "Graph";
			this.Text = "Graph";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Graph_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		/// <summary>
		/// Represents chart for drawing graph
		/// </summary>
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;

		/// <summary>
		/// Button for closing graph window
		/// </summary>
		private System.Windows.Forms.Button buttonCloseGraph;

		/// <summary>
		/// Listbox which allow to change graph type
		/// </summary>
		private System.Windows.Forms.ListBox graphTypeBox;

		/// <summary>
		/// Listbox which allow to change graph color
		/// </summary>
		private System.Windows.Forms.ListBox graphColorBox;

		/// <summary>
		/// TrackBar element which sets axis x minimum
		/// </summary>
		private System.Windows.Forms.TrackBar trackBarMin;

		/// <summary>
		/// TrackBar element which sets axis x maximum
		/// </summary>
		private System.Windows.Forms.TrackBar trackBarMax;
		private System.Windows.Forms.Button buttonColorDialog;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}