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
			this.greetingLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonMenu = new System.Windows.Forms.Button();
			this.listBoxX = new System.Windows.Forms.ListBox();
			this.listBoxY = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonDraw = new System.Windows.Forms.Button();
			this.labelHelp = new System.Windows.Forms.Label();
			this.buttonHelpToMenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer2
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// label1
			// 
			this.greetingLabel.AutoSize = true;
			this.greetingLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.greetingLabel.Font = new System.Drawing.Font("Segoe Script", 25F);
			this.greetingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.greetingLabel.Location = new System.Drawing.Point(234, 548);
			this.greetingLabel.Name = "label1";
			this.greetingLabel.Size = new System.Drawing.Size(2543, 399);
			this.greetingLabel.TabIndex = 0;
			this.greetingLabel.Text = "Добро пожаловать!\r\nЭто КДЗ Карпина Александра Николаевича БПИ176.\r\nНадеюсь, Вам п" +
    "онравится :)\r\n";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
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
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(1618, 801);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(656, 230);
			this.button3.TabIndex = 5;
			this.button3.Text = "На помощь!";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.buttonHelp_Click);
			// 
			// openFileDialog1
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(800, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(2496, 127);
			this.label3.TabIndex = 10;
			this.label3.Text = "Выберите столбцы, по которым построить графики:";
			this.label3.Visible = false;
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
			// label4
			// 
			this.labelHelp.AutoSize = true;
			this.labelHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelHelp.Font = new System.Drawing.Font("Segoe Print", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelHelp.Location = new System.Drawing.Point(78, 60);
			this.labelHelp.Name = "label4";
			this.labelHelp.Size = new System.Drawing.Size(3431, 2320);
			this.labelHelp.TabIndex = 13;
			this.labelHelp.Text = resources.GetString("label4.Text");
			this.labelHelp.Visible = false;
			// 
			// button1
			// 
			this.buttonHelpToMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonHelpToMenu.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHelpToMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonHelpToMenu.Location = new System.Drawing.Point(2968, 1741);
			this.buttonHelpToMenu.Name = "button1";
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
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBoxY);
			this.Controls.Add(this.listBoxX);
			this.Controls.Add(this.buttonMenu);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.greetingLabel);
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

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label greetingLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonMenu;
		private System.Windows.Forms.ListBox listBoxX;
		private System.Windows.Forms.ListBox listBoxY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonDraw;
		private System.Windows.Forms.Label labelHelp;
		private System.Windows.Forms.Button buttonHelpToMenu;
	}
}

