using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHW
{
	public partial class Graph : Form
	{
		private DataTable _table;
		private int _indexX;
		private int _indexY;
		private int trackVal;

		Dictionary<string, System.Windows.Forms.DataVisualization.Charting.SeriesChartType> graphNames
			= new Dictionary<string, System.Windows.Forms.DataVisualization.Charting.SeriesChartType>()
			{
			{"Line", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line },
				{"Point", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point },
				{"Bar", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar },
				{"Candlestick", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick },
				{"Column", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column }
			};

		Dictionary<string, System.Drawing.Color> graphColors
			= new Dictionary<string, System.Drawing.Color>()
			{
				{"Красный",System.Drawing.Color.Red },
				{"Зелыный",System.Drawing.Color.Green },
				{"Синий",System.Drawing.Color.Blue },
			};


		public Graph(DataTable table, int indexX, int indexY)
		{
			InitializeComponent();
			_table = table;
			_indexX = indexX;
			_indexY = indexY;
		}

		private void Graph_Load(object sender, EventArgs e)
		{
			trackVal = trackBar1.Value;
			chart.ChartAreas[0].CursorX.IsUserEnabled = true;
			chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
			chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
			chart.ChartAreas[0].CursorY.IsUserEnabled = true;
			chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
			chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
			chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
			chart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
			chart.ChartAreas[0].AxisX.Maximum = MaxX()*2;
			chart.ChartAreas[0].AxisX.Minimum = MinX()/2;

			chart.Series[0].Name = $"Зависимость {_table.Columns[_indexX].ColumnName} от {_table.Columns[_indexY].ColumnName}";

			foreach (var graphName in graphNames.Keys)
				graphTypeBox.Items.Add(graphName);
			foreach (var graphColor in graphColors.Keys)
				graphColorBox.Items.Add(graphColor);
			DrawGraph();
			

		}

		private void buttonCloseGraph_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart.Series[0].Points.Clear();
			chart.Series[0].ChartType = graphNames[graphTypeBox.Text];
			DrawGraph();
			
		}

		private void graphColorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart.Series[0].Points.Clear();
			chart.Series[0].Color = graphColors[graphColorBox.Text];
			DrawGraph(); 
		}

		private void DrawGraph()
		{
			chart.Series[0].Points.Clear();
			chart.Series[0].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending);
			DataView view = new DataView(_table);
			view.Sort = _table.Columns[_indexX].ColumnName + " ASC";
			
			_table = view.ToTable();
			
			for (int i =1;i<_table.Rows.Count;i++)
			{
				if (Convert.ToDouble(_table.Rows[i][_indexX])<chart.ChartAreas[0].AxisX.Maximum || Convert.ToDouble(_table.Rows[i][_indexX]) > chart.ChartAreas[0].AxisX.Minimum)
					chart.Series[0].Points.AddXY(_table.Rows[i][_indexX], _table.Rows[i][_indexY]);
			}
		}
		

		public double MaxX ()
		{
			List<double> lst = new List<Double>();
			for (int a = 0; a < _table.Rows.Count-2; a++)
			{
				lst.Add(Convert.ToDouble(_table.Rows[a][_indexX]));
			}
			return lst.Max();
		}

		public double MinX()
		{
			List<double> lst = new List<Double>();
			for (int a = 0; a < _table.Rows.Count-2; a++)
			{
				lst.Add(Convert.ToDouble(_table.Rows[a][_indexX]));
			}
			return lst.Min();
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			if (trackVal < trackBar1.Value)
			{
				chart.ChartAreas[0].AxisX.Minimum = chart.ChartAreas[0].AxisX.Minimum * 1.05;
				chart.ChartAreas[0].AxisX.Maximum = chart.ChartAreas[0].AxisX.Maximum / 1.05;
				trackVal = trackBar1.Value;

			}
			else
			{
				chart.ChartAreas[0].AxisX.Minimum = chart.ChartAreas[0].AxisX.Minimum /1.05;
				chart.ChartAreas[0].AxisX.Maximum = chart.ChartAreas[0].AxisX.Maximum * 1.05;
				trackVal = trackBar1.Value;
			}
			DrawGraph();
		}
	}
	}

