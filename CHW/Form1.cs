using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace CHW
{
	public partial class Form1 : Form
	{
		private int counter = 0;
		private const int GREETINGS_TICK_TIME = 1000;


		public Form1()
		{
			InitializeComponent();
		}

		private void ChangeMenuState(bool state)
		{
			button1.Visible = state;
			button2.Visible = state;
			button3.Visible = state;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Enabled = false;  // таймер включен
			timer2.Interval = GREETINGS_TICK_TIME;
			timer2.Enabled = true;
			ChangeMenuState(false);			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
				string temp = label1.Text;
				if (temp.Length > 0)
					label1.Text = temp.Substring(0, temp.Length - 1);
				else
				{
					timer1.Enabled = false;
					ChangeMenuState(true);
				}
		}	
		

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
				timer2.Enabled = false;
				timer1.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string filePath = string.Empty;
			string fileExt = string.Empty;
			openFileDialog1.Filter = "Excel Files| *.xls; *.xlsx; *.xlsm";
			openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			string filePath = string.Empty;
			string fileExt = string.Empty;
			try
			{
				filePath = openFileDialog1.FileName; //get the path of the file  
				fileExt = Path.GetExtension(filePath); //get the file extension  
				if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
				{
					LoadFile(filePath);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
			}

			private void LoadFile(string filePath)
			{
				System.Data.OleDb.OleDbConnection MyConnection;
				System.Data.DataSet DtSet;
				System.Data.OleDb.OleDbDataAdapter MyCommand;
				MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" +
					$"Data Source='{filePath}';Extended Properties=Excel 8.0;");
				// :TODO Сделать, чтобы был выбор листа
				MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Worksheet$]", MyConnection);
				DtSet = new System.Data.DataSet();
				//this.ShowDialog 
				MyCommand.Fill(DtSet);
				dataGridView1.DataSource = DtSet.Tables[0];
				button1.Visible = false;
				button2.Visible = false;
				button3.Visible = false;
				dataGridView1.Visible = true;
				MyConnection.Close();
			}
		}
	}
}

