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
	public partial class Data : Form
	{
		
		public Data(DataTable data)
		{
			InitializeComponent();
			dataTable.DataSource = data;
			dataTable.Visible = true;
		}

		private void Data_Load(object sender, EventArgs e)
		{

		}

		private void buttonCloseGraph_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
