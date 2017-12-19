namespace CHW
{
	partial class Data
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataTable = new System.Windows.Forms.DataGridView();
			this.buttonCloseGraph = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// dataTable
			// 
			this.dataTable.AllowUserToAddRows = false;
			this.dataTable.AllowUserToDeleteRows = false;
			this.dataTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataTable.Location = new System.Drawing.Point(42, 462);
			this.dataTable.Name = "dataTable";
			this.dataTable.ReadOnly = true;
			this.dataTable.RowTemplate.Height = 40;
			this.dataTable.Size = new System.Drawing.Size(3730, 1554);
			this.dataTable.TabIndex = 0;
			this.dataTable.Visible = false;
			// 
			// buttonCloseGraph
			// 
			this.buttonCloseGraph.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonCloseGraph.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCloseGraph.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonCloseGraph.Location = new System.Drawing.Point(2960, 46);
			this.buttonCloseGraph.Name = "buttonCloseGraph";
			this.buttonCloseGraph.Size = new System.Drawing.Size(769, 307);
			this.buttonCloseGraph.TabIndex = 13;
			this.buttonCloseGraph.Text = "Закрыть!";
			this.buttonCloseGraph.UseVisualStyleBackColor = false;
			this.buttonCloseGraph.Click += new System.EventHandler(this.buttonCloseGraph_Click);
			// 
			// Data
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(3808, 2072);
			this.Controls.Add(this.buttonCloseGraph);
			this.Controls.Add(this.dataTable);
			this.Name = "Data";
			this.Text = "Data";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Data_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		/// <summary>
		/// DataGrid to show provided datatable
		/// </summary>
		private System.Windows.Forms.DataGridView dataTable;

		/// <summary>
		/// Button, which calls event buttonClose
		/// </summary>
		private System.Windows.Forms.Button buttonCloseGraph;
	}
}