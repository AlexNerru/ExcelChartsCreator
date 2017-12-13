namespace CHW
{
	partial class Form1
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
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button4 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonDraw = new System.Windows.Forms.Button();
			this.buttonHelp2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 25F);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(234, 548);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(2543, 399);
			this.label1.TabIndex = 0;
			this.label1.Text = "Добро пожаловать!\r\nЭто КДЗ Карпина Александра Николаевича БПИ176.\r\nНадеюсь, Вам п" +
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
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(1618, 409);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(656, 230);
			this.button2.TabIndex = 4;
			this.button2.Text = "Открыть!";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(1618, 817);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(656, 230);
			this.button3.TabIndex = 5;
			this.button3.Text = "На помощь!";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new System.Drawing.Point(1618, 1391);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(656, 230);
			this.button4.TabIndex = 6;
			this.button4.Text = "В меню!";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listBox1.Font = new System.Drawing.Font("Segoe Script", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 84;
			this.listBox1.Location = new System.Drawing.Point(961, 251);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(620, 256);
			this.listBox1.TabIndex = 8;
			this.listBox1.Visible = false;
			// 
			// listBox2
			// 
			this.listBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listBox2.Font = new System.Drawing.Font("Segoe Script", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox2.ForeColor = System.Drawing.SystemColors.Menu;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 84;
			this.listBox2.Location = new System.Drawing.Point(2300, 266);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(801, 256);
			this.listBox2.TabIndex = 9;
			this.listBox2.Visible = false;
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
			// buttonHelp2
			// 
			this.buttonHelp2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonHelp2.Font = new System.Drawing.Font("Segoe Script", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHelp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonHelp2.Location = new System.Drawing.Point(1618, 1012);
			this.buttonHelp2.Name = "buttonHelp2";
			this.buttonHelp2.Size = new System.Drawing.Size(656, 230);
			this.buttonHelp2.TabIndex = 12;
			this.buttonHelp2.Text = "На помощь!";
			this.buttonHelp2.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Desktop;
			this.ClientSize = new System.Drawing.Size(3788, 2072);
			this.Controls.Add(this.buttonHelp2);
			this.Controls.Add(this.buttonDraw);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Замечательное КДЗ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonDraw;
		private System.Windows.Forms.Button buttonHelp2;
	}
}

