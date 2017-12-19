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
	/// Class represents data and demonstrates it via gridView
	/// </summary>
	public partial class Data : Form
	{
		
		/// <summary>
		/// Constructor for data window
		/// </summary>
		/// <param name="data"></param>
		public Data(DataTable data)
		{
			InitializeComponent();
			dataTable.DataSource = data;
			dataTable.Visible = true;
		}

		/// <summary>
		/// Empty method which is called when form has loaded
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Data_Load(object sender, EventArgs e)
		{

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


	}
}
