namespace DoAn_CuoiKy
{
	partial class FormThemTkUser
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
			this.panelTK = new System.Windows.Forms.Panel();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
			this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
			this.btnThemTaiKhoan = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaUser = new System.Windows.Forms.TextBox();
			this.txtRoles = new System.Windows.Forms.TextBox();
			this.lbl10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenDN = new System.Windows.Forms.TextBox();
			this.lbl = new System.Windows.Forms.Label();
			this.dtaGridViewAdmin = new System.Windows.Forms.DataGridView();
			this.panelTK.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtaGridViewAdmin)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTK
			// 
			this.panelTK.BackColor = System.Drawing.Color.Silver;
			this.panelTK.Controls.Add(this.txtMatKhau);
			this.panelTK.Controls.Add(this.panel2);
			this.panelTK.Controls.Add(this.label1);
			this.panelTK.Controls.Add(this.txtMaUser);
			this.panelTK.Controls.Add(this.txtRoles);
			this.panelTK.Controls.Add(this.lbl10);
			this.panelTK.Controls.Add(this.label2);
			this.panelTK.Controls.Add(this.txtTenDN);
			this.panelTK.Controls.Add(this.lbl);
			this.panelTK.Location = new System.Drawing.Point(46, 221);
			this.panelTK.Margin = new System.Windows.Forms.Padding(4);
			this.panelTK.Name = "panelTK";
			this.panelTK.Size = new System.Drawing.Size(454, 266);
			this.panelTK.TabIndex = 7;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(117, 105);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(210, 22);
			this.txtMatKhau.TabIndex = 9;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnXoaTaiKhoan);
			this.panel2.Controls.Add(this.btnSuaTaiKhoan);
			this.panel2.Controls.Add(this.btnThemTaiKhoan);
			this.panel2.Location = new System.Drawing.Point(13, 194);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(444, 59);
			this.panel2.TabIndex = 5;
			// 
			// btnXoaTaiKhoan
			// 
			this.btnXoaTaiKhoan.Location = new System.Drawing.Point(156, 5);
			this.btnXoaTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
			this.btnXoaTaiKhoan.Size = new System.Drawing.Size(85, 47);
			this.btnXoaTaiKhoan.TabIndex = 1;
			this.btnXoaTaiKhoan.Text = "Xoa";
			this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
			this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
			// 
			// btnSuaTaiKhoan
			// 
			this.btnSuaTaiKhoan.Location = new System.Drawing.Point(296, 4);
			this.btnSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
			this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
			this.btnSuaTaiKhoan.Size = new System.Drawing.Size(85, 47);
			this.btnSuaTaiKhoan.TabIndex = 6;
			this.btnSuaTaiKhoan.Text = "Sua";
			this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
			this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
			// 
			// btnThemTaiKhoan
			// 
			this.btnThemTaiKhoan.Location = new System.Drawing.Point(14, 4);
			this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
			this.btnThemTaiKhoan.Size = new System.Drawing.Size(85, 47);
			this.btnThemTaiKhoan.TabIndex = 0;
			this.btnThemTaiKhoan.Text = "Them";
			this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
			this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 150);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "User Roles";
			// 
			// txtMaUser
			// 
			this.txtMaUser.Location = new System.Drawing.Point(117, 16);
			this.txtMaUser.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaUser.Name = "txtMaUser";
			this.txtMaUser.Size = new System.Drawing.Size(210, 22);
			this.txtMaUser.TabIndex = 3;
			// 
			// txtRoles
			// 
			this.txtRoles.Location = new System.Drawing.Point(119, 150);
			this.txtRoles.Margin = new System.Windows.Forms.Padding(4);
			this.txtRoles.Name = "txtRoles";
			this.txtRoles.Size = new System.Drawing.Size(210, 22);
			this.txtRoles.TabIndex = 10;
			// 
			// lbl10
			// 
			this.lbl10.AutoSize = true;
			this.lbl10.Location = new System.Drawing.Point(4, 68);
			this.lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl10.Name = "lbl10";
			this.lbl10.Size = new System.Drawing.Size(102, 16);
			this.lbl10.TabIndex = 2;
			this.lbl10.Text = "Tên Đăng Nhập";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(24, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mật Khẩu";
			// 
			// txtTenDN
			// 
			this.txtTenDN.Location = new System.Drawing.Point(117, 62);
			this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.Size = new System.Drawing.Size(210, 22);
			this.txtTenDN.TabIndex = 4;
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbl.Location = new System.Drawing.Point(24, 22);
			this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(58, 16);
			this.lbl.TabIndex = 1;
			this.lbl.Text = "Mã User";
			// 
			// dtaGridViewAdmin
			// 
			this.dtaGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtaGridViewAdmin.Location = new System.Drawing.Point(548, 49);
			this.dtaGridViewAdmin.Name = "dtaGridViewAdmin";
			this.dtaGridViewAdmin.RowHeadersWidth = 51;
			this.dtaGridViewAdmin.RowTemplate.Height = 24;
			this.dtaGridViewAdmin.Size = new System.Drawing.Size(658, 650);
			this.dtaGridViewAdmin.TabIndex = 8;
			this.dtaGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridViewAdmin_CellClick);
			// 
			// FormThemTkUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1453, 763);
			this.Controls.Add(this.dtaGridViewAdmin);
			this.Controls.Add(this.panelTK);
			this.Name = "FormThemTkUser";
			this.Text = "FormThemTkUser";
			this.Load += new System.EventHandler(this.FormThemTkUser_Load);
			this.panelTK.ResumeLayout(false);
			this.panelTK.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtaGridViewAdmin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTK;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnXoaTaiKhoan;
		private System.Windows.Forms.Button btnSuaTaiKhoan;
		private System.Windows.Forms.Button btnThemTaiKhoan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaUser;
		private System.Windows.Forms.TextBox txtRoles;
		private System.Windows.Forms.Label lbl10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenDN;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.DataGridView dtaGridViewAdmin;
	}
}