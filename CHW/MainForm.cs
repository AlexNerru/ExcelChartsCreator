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
	/// <summary>
	/// Main class, which is user for all interactions with user
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Table of data which was loaded from file
		/// </summary>
		private DataTable _table; 

		/// <summary>
		/// Text of first label
		/// </summary>
		private readonly string GREETINGS_LABEL_TEXT;

		/// <summary>
		/// Randomiser
		/// </summary>
		Random rand = new Random();

		public MainForm()
		{
			InitializeComponent();
			GREETINGS_LABEL_TEXT = greetingLabel.Text;
		}

		/// <summary>
		/// Changes visible property of main menu items
		/// </summary>
		/// <param name="state">true - visible, false - not</param>
		private void ChangeMenuState(bool state)
		{
			buttonClose.Visible = state;
			buttonOpen.Visible = state;
			button3.Visible = state;
			
		}

		/// <summary>
		/// Changes visible property of drawing graph menu items
		/// </summary>
		/// <param name="state">true - visible, false - not<</param>
		private void ChangeGraphMenuStatus (bool state)
		{
			buttonMenu.Visible = state;
			listBoxX.Visible = state;
			label3.Visible = state;
			listBoxY.Visible = state;
			buttonDraw.Visible = state;
		}

		/// <summary>
		/// Event which is calles immediatly, when form has loaded
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			timer.Enabled = true;  // таймер включен
			timer.Interval = 100;
			ChangeMenuState(false);
			ChangeGraphMenuStatus(false);
			greetingLabel.Text = String.Empty;
		}

		/// <summary>
		/// Timer ticker, which draws "greetings label"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer_Tick(object sender, EventArgs e)
		{

			if (greetingLabel.Text.Length < GREETINGS_LABEL_TEXT.Length)
			{
				greetingLabel.Text = GREETINGS_LABEL_TEXT.Substring(0, greetingLabel.Text.Length + 1);
				timer.Interval= rand.Next(50, 150);
			}
			else
			{
				timer.Enabled = false;
				greetingLabel.Visible = false;
				ChangeMenuState(true);
			}
		}		

		/// <summary>
		/// Event, which calls after clicking "close" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Event, which calls after clicking "open" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonOpen_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "Excel Files| *.xls; *.xlsx";
			openFileDialog.ShowDialog();
		}

		/// <summary>
		/// Event, which calls when user clicks "ok" button in open file dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void openFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			listBoxX.Items.Clear();
			listBoxY.Items.Clear();
			string filePath = string.Empty;
			string fileExt = string.Empty;
			try
			{
				filePath = openFileDialog.FileName;  
				fileExt = Path.GetExtension(filePath); 
				if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
				{

					List<string> numericColumnsNames = new List<string>();
					numericColumnsNames = LoadFile(filePath);
					foreach (var columnName in numericColumnsNames)
					{
						listBoxX.Items.Add(columnName);
						listBoxY.Items.Add(columnName);
					}

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка! Не удалось прочитать файл: " + ex.Message);
			}
		}

		/// <summary>
		/// Loads chosen Excel file
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns>Names of colums which has numeric values</returns>
		private List<string> LoadFile(string filePath)
		{
			System.Data.OleDb.OleDbConnection MyConnection;
			System.Data.DataSet DtSet;
			System.Data.OleDb.OleDbDataAdapter MyCommand;
			MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" +
				$"Data Source='{filePath}';Extended Properties=Excel 8.0;");
			MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Worksheet$]", MyConnection);
			DtSet = new System.Data.DataSet();
			MyCommand.Fill(DtSet);			
			_table = DtSet.Tables[0];
			Data dataForm = new Data(DtSet.Tables[0]);
			ChangeMenuState(false);
			ChangeGraphMenuStatus(true);
			dataForm.Show();
			MyConnection.Close();
			
			return GetNumericColumnsNames(DtSet.Tables[0]);
			
		}

		/// <summary>
		/// Creates list of names of numeric type colums
		/// </summary>
		/// <param name="dataTable"></param>
		/// <returns>list of string names</returns>
		private List<string> GetNumericColumnsNames (DataTable dataTable)
		{
			List<string> names = new List<string>();
			foreach (DataColumn dataColumn in dataTable.Columns)
			{
				if (IsNumericType(dataColumn.DataType))
				{
					names.Add(dataColumn.ColumnName);
				}
			}
			return names;

		}

		/// <summary>
		/// Checks if Type object is numeric
		/// </summary>
		/// <param name="type"></param>
		/// <returns>true if type is numeric, false if not</returns>
		private bool IsNumericType(Type type)
		{

			switch (Type.GetTypeCode(type))
			{
				case TypeCode.Byte:
				case TypeCode.SByte:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.Decimal:
				case TypeCode.Double:
				case TypeCode.Single:
					return true;
				default:
					return false;
			}
		}

		/// <summary>
		/// Shows main menu and hides graph menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonToMenu_Click(object sender, EventArgs e)
		{
			ChangeGraphMenuStatus(false);
			ChangeMenuState(true);
		}

		/// <summary>
		/// Creates new Graph object from a table and shows it
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDraw_Click(object sender, EventArgs e)
		{
			int indexX, indexY;

			if (listBoxX.Text != listBoxY.Text)
			{
				indexX = _table.Columns[listBoxX.Text].Ordinal;
				indexY = _table.Columns[listBoxY.Text].Ordinal;
				Graph graph = new Graph(_table,indexX,indexY);
				graph.Show();
			}
			else
			{
				MessageBox.Show("Вы выбрали два одинаковых столбца!");
			}

		}

		/// <summary>
		/// Shows help and hides main menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonHelp_Click(object sender, EventArgs e)
		{
			ChangeGraphMenuStatus(false);
			ChangeMenuState(false);
			labelHelp.Visible = true;
			buttonHelpToMenu.Visible = true;
		}

		/// <summary>
		/// Hides labelHelp and shows main menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonHelpToMenu_Click(object sender, EventArgs e)
		{
			labelHelp.Visible = false;
			ChangeGraphMenuStatus(false);
			ChangeMenuState(true);
			buttonHelpToMenu.Visible = false;
		}

		
	}
}


