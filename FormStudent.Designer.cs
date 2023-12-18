namespace DoAn_CuoiKy
{
	partial class FormStudent
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInformationToolStripMenuItem,
            this.thiToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1490, 30);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // thiToolStripMenuItem
            // 
            this.thiToolStripMenuItem.Name = "thiToolStripMenuItem";
            this.thiToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.thiToolStripMenuItem.Text = "Tra Cuu Ket Qua";
            this.thiToolStripMenuItem.Click += new System.EventHandler(this.thiToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet;
            this.dangXuatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangXuatToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 641);
            this.panel1.TabIndex = 6;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
    }
}