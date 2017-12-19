namespace CHW
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.labelGreetings = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonMenu = new System.Windows.Forms.Button();
			this.listBoxX = new System.Windows.Forms.ListBox();
			this.listBoxY = new System.Windows.Forms.ListBox();
			this.labelChooseColumns = new System.Windows.Forms.Label();
			this.buttonDraw = new System.Windows.Forms.Button();
			this.labelHelp = new System.Windows.Forms.Label();
			this.buttonHelpToMenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// labelGreetings
			// 
			this.labelGreetings.AutoSize = true;
			this.labelGreetings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelGreetings.Font = new System.Drawing.Font("Segoe Script", 25F);
			this.labelGreetings.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelGreetings.Location = new System.Drawing.Point(234, 548);
			this.labelGreetings.Name = "labelGreetings";
			this.labelGreetings.Size = new System.Drawing.Size(2543, 399);
			this.labelGreetings.TabIndex = 0;
			this.labelGreetings.Text = "Добро пожаловать!\r\nЭто КДЗ Карпина Александра Николаевича БПИ176.\r\nНадеюсь, Вам п" +
    "онравится :)\r\n";
			// 
			// buttonClose
			// 
			this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonClose.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonClose.Location = new System.Drawing.Point(1618, 1172);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(656, 230);
			this.buttonClose.TabIndex = 2;
			this.buttonClose.Text = "Закрыть!";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonOpen
			// 
			this.buttonOpen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonOpen.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonOpen.Location = new System.Drawing.Point(1618, 409);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(656, 230);
			this.buttonOpen.TabIndex = 4;
			this.buttonOpen.Text = "Открыть!";
			this.buttonOpen.UseVisualStyleBackColor = false;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// button3
			// 
			this.buttonHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonHelp.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonHelp.Location = new System.Drawing.Point(1618, 784);
			this.buttonHelp.Name = "button3";
			this.buttonHelp.Size = new System.Drawing.Size(656, 230);
			this.buttonHelp.TabIndex = 5;
			this.buttonHelp.Text = "На помощь!";
			this.buttonHelp.UseVisualStyleBackColor = false;
			this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// buttonMenu
			// 
			this.buttonMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonMenu.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonMenu.Location = new System.Drawing.Point(1618, 1391);
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.Size = new System.Drawing.Size(656, 230);
			this.buttonMenu.TabIndex = 6;
			this.buttonMenu.Text = "В меню!";
			this.buttonMenu.UseVisualStyleBackColor = false;
			this.buttonMenu.Click += new System.EventHandler(this.buttonToMenu_Click);
			// 
			// listBoxX
			// 
			this.listBoxX.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listBoxX.Font = new System.Drawing.Font("Segoe Script", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxX.ForeColor = System.Drawing.SystemColors.Menu;
			this.listBoxX.FormattingEnabled = true;
			this.listBoxX.ItemHeight = 84;
			this.listBoxX.Location = new System.Drawing.Point(961, 251);
			this.listBoxX.Name = "listBoxX";
			this.listBoxX.Size = new System.Drawing.Size(620, 256);
			this.listBoxX.TabIndex = 8;
			this.listBoxX.Visible = false;
			// 
			// listBoxY
			// 
			this.listBoxY.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listBoxY.Font = new System.Drawing.Font("Segoe Script", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxY.ForeColor = System.Drawing.SystemColors.Menu;
			this.listBoxY.FormattingEnabled = true;
			this.listBoxY.ItemHeight = 84;
			this.listBoxY.Location = new System.Drawing.Point(2300, 266);
			this.listBoxY.Name = "listBoxY";
			this.listBoxY.Size = new System.Drawing.Size(801, 256);
			this.listBoxY.TabIndex = 9;
			this.listBoxY.Visible = false;
			// 
			// labelChooseColumns
			// 
			this.labelChooseColumns.AutoSize = true;
			this.labelChooseColumns.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelChooseColumns.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelChooseColumns.Location = new System.Drawing.Point(800, 60);
			this.labelChooseColumns.Name = "labelChooseColumns";
			this.labelChooseColumns.Size = new System.Drawing.Size(2496, 127);
			this.labelChooseColumns.TabIndex = 10;
			this.labelChooseColumns.Text = "Выберите столбцы, по которым построить графики:";
			this.labelChooseColumns.Visible = false;
			// 
			// buttonDraw
			// 
			this.buttonDraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonDraw.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonDraw.Location = new System.Drawing.Point(1618, 668);
			this.buttonDraw.Name = "buttonDraw";
			this.buttonDraw.Size = new System.Drawing.Size(656, 230);
			this.buttonDraw.TabIndex = 11;
			this.buttonDraw.Text = "Построить!";
			this.buttonDraw.UseVisualStyleBackColor = false;
			this.buttonDraw.Visible = false;
			this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
			// 
			// labelHelp
			// 
			this.labelHelp.AutoSize = true;
			this.labelHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelHelp.Font = new System.Drawing.Font("Segoe Print", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelHelp.Location = new System.Drawing.Point(78, 60);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(3431, 2320);
			this.labelHelp.TabIndex = 13;
			this.labelHelp.Text = resources.GetString("labelHelp.Text");
			this.labelHelp.Visible = false;
			// 
			// buttonHelpToMenu
			// 
			this.buttonHelpToMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonHelpToMenu.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHelpToMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonHelpToMenu.Location = new System.Drawing.Point(2968, 1741);
			this.buttonHelpToMenu.Name = "buttonHelpToMenu";
			this.buttonHelpToMenu.Size = new System.Drawing.Size(656, 230);
			this.buttonHelpToMenu.TabIndex = 14;
			this.buttonHelpToMenu.Text = "В меню!";
			this.buttonHelpToMenu.UseVisualStyleBackColor = false;
			this.buttonHelpToMenu.Visible = false;
			this.buttonHelpToMenu.Click += new System.EventHandler(this.buttonHelpToMenu_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Desktop;
			this.ClientSize = new System.Drawing.Size(3788, 2072);
			this.Controls.Add(this.buttonHelpToMenu);
			this.Controls.Add(this.buttonDraw);
			this.Controls.Add(this.labelChooseColumns);
			this.Controls.Add(this.listBoxY);
			this.Controls.Add(this.listBoxX);
			this.Controls.Add(this.buttonMenu);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.labelGreetings);
			this.Controls.Add(this.labelHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Замечательное КДЗ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		/// <summary>
		/// Timer for drawing Greetings Label
		/// </summary>
		private System.Windows.Forms.Timer timer;

		/// <summary>
		/// Text which to greet user
		/// </summary>
		private System.Windows.Forms.Label labelGreetings;

		/// <summary>
		/// Button to close app
		/// </summary>
		private System.Windows.Forms.Button buttonClose;

		/// <summary>
		/// Button to open file via openFileDialog
		/// </summary>
		private System.Windows.Forms.Button buttonOpen;

		/// <summary>
		/// Button to show help
		/// </summary>
		private System.Windows.Forms.Button buttonHelp;

		/// <summary>
		/// OpenFileDialog to work with files
		/// </summary>
		private System.Windows.Forms.OpenFileDialog openFileDialog;

		/// <summary>
		/// Button to return to menu
		/// </summary>
		private System.Windows.Forms.Button buttonMenu;

		/// <summary>
		/// ListBox for names of X columns
		/// </summary>
		private System.Windows.Forms.ListBox listBoxX;

		/// <summary>
		/// ListBox for names of Y column
		/// </summary>
		private System.Windows.Forms.ListBox listBoxY;

		/// <summary>
		/// Shows information that user need to choose columns for x and y
		/// </summary>
		private System.Windows.Forms.Label labelChooseColumns;
		
		/// <summary>
		/// Is used to call drawGraph event
		/// </summary>
		private System.Windows.Forms.Button buttonDraw;

		/// <summary>
		/// Contains help information
		/// </summary>
		private System.Windows.Forms.Label labelHelp;

		/// <summary>
		/// Button to returm to main menu
		/// </summary>
		private System.Windows.Forms.Button buttonHelpToMenu;
	}
}

