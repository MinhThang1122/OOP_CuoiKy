﻿namespace DoAn_CuoiKy
{
	partial class FormAdmin
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.themTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.themThongTinUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.themThongTinGiaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.themLopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTaiKhoanToolStripMenuItem,
            this.themThongTinUserToolStripMenuItem,
            this.themThongTinGiaoVienToolStripMenuItem,
            this.themLopHocToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1338, 28);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// themTaiKhoanToolStripMenuItem
			// 
			this.themTaiKhoanToolStripMenuItem.Name = "themTaiKhoanToolStripMenuItem";
			this.themTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
			this.themTaiKhoanToolStripMenuItem.Text = "Them Tai Khoan";
			this.themTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.themTaiKhoanToolStripMenuItem_Click);
			// 
			// themThongTinUserToolStripMenuItem
			// 
			this.themThongTinUserToolStripMenuItem.Name = "themThongTinUserToolStripMenuItem";
			this.themThongTinUserToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
			this.themThongTinUserToolStripMenuItem.Text = "Them Thong Tin Hoc Vien";
			this.themThongTinUserToolStripMenuItem.Click += new System.EventHandler(this.themThongTinUserToolStripMenuItem_Click);
			// 
			// themThongTinGiaoVienToolStripMenuItem
			// 
			this.themThongTinGiaoVienToolStripMenuItem.Name = "themThongTinGiaoVienToolStripMenuItem";
			this.themThongTinGiaoVienToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
			this.themThongTinGiaoVienToolStripMenuItem.Text = "Them Thong Tin Giao Vien";
			this.themThongTinGiaoVienToolStripMenuItem.Click += new System.EventHandler(this.themThongTinGiaoVienToolStripMenuItem_Click);
			// 
			// themLopHocToolStripMenuItem
			// 
			this.themLopHocToolStripMenuItem.Name = "themLopHocToolStripMenuItem";
			this.themLopHocToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
			this.themLopHocToolStripMenuItem.Text = "Them Lop Hoc";
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1338, 621);
			this.panel1.TabIndex = 12;
			// 
			// FormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1338, 649);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormAdmin";
			this.Text = "FormAdmin";
			this.Load += new System.EventHandler(this.FormAdmin_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem themTaiKhoanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem themThongTinUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem themThongTinGiaoVienToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem themLopHocToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
	}
}