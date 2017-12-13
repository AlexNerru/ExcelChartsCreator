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

		Dictionary<string, System.Windows.Forms.DataVisualization.Charting.SeriesChartType> graphNames
			= new Dictionary<string, System.Windows.Forms.DataVisualization.Charting.SeriesChartType>()
			{
			{"Line", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line },
				{"Point", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point },
				{"Bar", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar },
				{"Candlestick", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick },
				{"Column", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column },
				{"Kagi", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi }
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
			chart.ChartAreas[0].CursorX.IsUserEnabled = true;
			chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
			chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			//chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
			chart.ChartAreas[0].CursorY.IsUserEnabled = true;
			chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
			chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
			//chart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
			
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
			chart.Series[0].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending);
			DataView view = new DataView(_table);
			view.Sort = _table.Columns[_indexX].ColumnName + " ASC";
			_table = view.ToTable();

			foreach (DataRow dataRow in _table.Rows)
			{
				chart.Series[0].Points.AddXY(dataRow[_indexX], dataRow[_indexY]);
				Console.WriteLine(dataRow[_indexX].GetType());
			}

		}
	}
	}

