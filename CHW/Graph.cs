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
		private int _min;
		private int _max;
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
			_min = 0;
			_max = _table.Rows.Count;
			trackVal = trackBarMin.Value;
			chart.ChartAreas[0].CursorX.IsUserEnabled = true;
			chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
			chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
			chart.ChartAreas[0].CursorY.IsUserEnabled = true;
			chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
			chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
			chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
			chart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
			chart.ChartAreas[0].AxisX.Maximum = MaxX()*1.1;
			chart.ChartAreas[0].AxisX.Minimum = MinX()/1.1;

			chart.Series[0].Name = $"Зависимость {_table.Columns[_indexX].ColumnName} от {_table.Columns[_indexY].ColumnName}";

			trackBarMin.Minimum = 1;
			trackBarMin.Maximum = _table.Rows.Count;
			trackBarMin.Value = 1;
			trackBarMax.Minimum = 1;
			trackBarMax.Maximum = _table.Rows.Count;
			trackBarMax.Value = _table.Rows.Count;



			chart.Series[0].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending);
			DataView view = new DataView(_table);
			view.Sort = _table.Columns[_indexX].ColumnName + " ASC";

			_table = view.ToTable();

			foreach (var graphName in graphNames.Keys)
				graphTypeBox.Items.Add(graphName);
			foreach (var graphColor in graphColors.Keys)
				graphColorBox.Items.Add(graphColor);
			DrawGraph(1, _table.Rows.Count-2);
			

		}

		private void buttonCloseGraph_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart.Series[0].Points.Clear();
			chart.Series[0].ChartType = graphNames[graphTypeBox.Text];
			//DrawGraph();
			
		}

		private void graphColorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart.Series[0].Points.Clear();
			chart.Series[0].Color = graphColors[graphColorBox.Text];
			//DrawGraph(); 
		}

		private void DrawGraph(int min, int max)
		{
			chart.Series[0].Points.Clear();
			double localMin = MaxX();
			double localMax = 0;
			for (int i =min;i<max;i++)
			{
				if (Convert.ToDouble(_table.Rows[i][_indexX]) > localMax)
					localMax = Convert.ToDouble(_table.Rows[i][_indexX]);
				if (Convert.ToDouble(_table.Rows[i][_indexX]) < localMin)
					localMin = Convert.ToDouble(_table.Rows[i][_indexX]);
				chart.Series[0].Points.AddXY(_table.Rows[i][_indexX], _table.Rows[i][_indexY]);
			}
			chart.ChartAreas[0].AxisX.Maximum = localMax * 1.1;
			chart.ChartAreas[0].AxisX.Minimum = localMin / 1.1;

		}
		

		public double MaxX ()
		{
			List<double> lst = new List<Double>();
			for (int a = 1; a < _table.Rows.Count-2; a++)
			{
				lst.Add(Convert.ToDouble(_table.Rows[a][_indexX]));
			}
			return lst.Max();
		}

		public double MinX()
		{
			List<double> lst = new List<Double>();
			for (int a = 1; a < _table.Rows.Count-2; a++)
			{
				lst.Add(Convert.ToDouble(_table.Rows[a][_indexX]));
			}
			return lst.Min();
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{

			
		}

		private void trackBarMax_Scroll(object sender, EventArgs e)
		{
			_max = trackBarMax.Value;
			DrawGraph(_min, _max);
		}

		private void trackBarMin_Scroll(object sender, EventArgs e)
		{
			_min = trackBarMin.Value;
			DrawGraph(_min, _max);
		}
	}
	}

