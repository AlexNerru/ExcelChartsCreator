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
	/// <summary>
	/// Class which represents the graph, built on two codens of datatable
	/// </summary>
	public partial class Graph : Form
	{
		/// <summary>
		/// Const to avoid "strange numbers in code"
		/// </summary>
		const int INDEX_OF_FIRST_VALID_EL = 1;

		/// <summary>
		/// Data for drawing a graph
		/// </summary>	
		private DataTable _table;

		/// <summary>
		/// Index of column with x coordinates
		/// </summary>
		private int _indexX;

		/// <summary>
		/// Index of column with y coordinates
		/// </summary>
		private int _indexY;

		/// <summary>
		/// Index of min element in column, which will be shown on graph
		/// </summary>
		private int _min;

		/// <summary>
		/// Index of max element in column, which will be shown on graph
		/// </summary>
		private int _max;

		/// <summary>
		/// Dictionary which is used to  store string names of graph types
		/// </summary>
		Dictionary<string, System.Windows.Forms.DataVisualization.Charting.SeriesChartType> graphNames
			= new Dictionary<string, System.Windows.Forms.DataVisualization.Charting.SeriesChartType>()
			{
			{"Line", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line },
				{"Point", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point },
				{"Bar", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar },
				{"Candlestick", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick },
				{"Column", System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column }
			};

		/// <summary>
		/// Dictionary which is used to store string names of colors
		/// </summary>
		Dictionary<string, System.Drawing.Color> graphColors
			= new Dictionary<string, System.Drawing.Color>()
			{
				{"Красный",System.Drawing.Color.Red },
				{"Зелыный",System.Drawing.Color.Green },
				{"Синий",System.Drawing.Color.Blue },
			};

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="table">Data for graph</param>
		/// <param name="indexX">Index of column whick will be used as X values</param>
		/// <param name="indexY">Index of column whick will be used as Y values</param>
		public Graph(DataTable table, int indexX, int indexY)
		{
			InitializeComponent();
			_table = table;
			_indexX = indexX;
			_indexY = indexY;
		}

		/// <summary>
		/// Event, called after loading a form, using to customise form and graph
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Graph_Load(object sender, EventArgs e)
		{
			_min = INDEX_OF_FIRST_VALID_EL;
			_max = _table.Rows.Count-INDEX_OF_FIRST_VALID_EL;
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

			//creating a legend
			chart.Series[0].Name = $"Зависимость {_table.Columns[_indexX].ColumnName} от {_table.Columns[_indexY].ColumnName}";


			trackBarMin.Minimum = INDEX_OF_FIRST_VALID_EL;
			trackBarMin.Maximum = _table.Rows.Count;
			trackBarMin.Value = INDEX_OF_FIRST_VALID_EL;
			trackBarMax.Minimum = INDEX_OF_FIRST_VALID_EL;
			trackBarMax.Maximum = _table.Rows.Count;
			trackBarMax.Value = _table.Rows.Count;


			//sorting data
			chart.Series[0].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending);
			DataView view = new DataView(_table);
			view.Sort = _table.Columns[_indexX].ColumnName + " ASC";

			_table = view.ToTable();

			//crates list box items
			foreach (var graphName in graphNames.Keys)
				graphTypeBox.Items.Add(graphName);
			foreach (var graphColor in graphColors.Keys)
				graphColorBox.Items.Add(graphColor);
			DrawGraph(INDEX_OF_FIRST_VALID_EL, _table.Rows.Count-2);
			

		}

		/// <summary>
		/// Event, which is called after clicking "close" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCloseGraph_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Event to change graph type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart.Series[0].Points.Clear();
			chart.Series[0].ChartType = graphNames[graphTypeBox.Text];
			DrawGraph(_min,_max);
			
		}

		/// <summary>
		/// Event to change graph color
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void graphColorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			chart.Series[0].Points.Clear();
			chart.Series[0].Color = graphColors[graphColorBox.Text];
			DrawGraph(_min, _max); 
		}

		/// <summary>
		/// Redraw graph
		/// </summary>
		/// <param name="min">index of min value X in column (index of min row)</param>
		/// <param name="max">index of max value X in column (index of min row)</param>
		private void DrawGraph(int min, int max)
		{
			chart.Series[0].Points.Clear();
			double localMin = MaxX();
			double localMax = 0;
			for (int i =min;i<max;i++)
			{
				try
				{
					if (Convert.ToDouble(_table.Rows[i][_indexX]) > localMax)
						localMax = Convert.ToDouble(_table.Rows[i][_indexX]);
					if (Convert.ToDouble(_table.Rows[i][_indexX]) < localMin)
						localMin = Convert.ToDouble(_table.Rows[i][_indexX]);
					chart.Series[0].Points.AddXY(_table.Rows[i][_indexX], _table.Rows[i][_indexY]);
				}
				catch (InvalidCastException e)
				{
					Console.WriteLine(e.Message);
				}
				catch (IndexOutOfRangeException e)
				{
					Console.WriteLine(e.Message);
				}
			}
			chart.ChartAreas[0].AxisX.Maximum = localMax * 1.1;
			chart.ChartAreas[0].AxisX.Minimum = localMin / 1.1;

		}
		
		/// <summary>
		/// Findes maximum element in column X
		/// </summary>
		/// <returns>element with max value</returns>
		public double MaxX ()
		{
			List<double> lst = new List<Double>();
			for (int a = INDEX_OF_FIRST_VALID_EL; a < _table.Rows.Count-2; a++)
			{
				lst.Add(Convert.ToDouble(_table.Rows[a][_indexX]));
			}
			return lst.Max();
		}

		/// <summary>
		/// Findes minimum element in column X
		/// </summary>
		/// <returns>element with min x value</returns>
		public double MinX()
		{
			List<double> lst = new List<Double>();
			for (int a = 1; a < _table.Rows.Count-2; a++)
			{
				lst.Add(Convert.ToDouble(_table.Rows[a][_indexX]));
			}
			return lst.Min();
		}

		/// <summary>
		/// Event,is called, when trackBar for min value value changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void trackBarMin_ValueChanged(object sender, EventArgs e)
		{
			trackBarMax.Minimum = (int)(trackBarMin.Value * 1.1);
			_min = trackBarMin.Value;
			DrawGraph(_min, _max);
		}

		/// <summary>
		/// Event,is called, when trackBar for max value value changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void trackBarMax_ValueChanged(object sender, EventArgs e)
		{
			trackBarMin.Maximum = (int)(trackBarMax.Value / 1.1);
			_max = trackBarMax.Value;
			DrawGraph(_min, _max);
		}
	}
	}

