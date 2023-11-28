namespace DoAn_CuoiKy
{
	partial class Form1
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
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.lblTaiKhoan = new System.Windows.Forms.Label();
			this.lblMatKhau = new System.Windows.Forms.Label();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Location = new System.Drawing.Point(180, 94);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(201, 22);
			this.txtTaiKhoan.TabIndex = 0;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(180, 169);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(199, 22);
			this.txtMatKhau.TabIndex = 1;
			// 
			// lblTaiKhoan
			// 
			this.lblTaiKhoan.AutoSize = true;
			this.lblTaiKhoan.Location = new System.Drawing.Point(177, 75);
			this.lblTaiKhoan.Name = "lblTaiKhoan";
			this.lblTaiKhoan.Size = new System.Drawing.Size(68, 16);
			this.lblTaiKhoan.TabIndex = 2;
			this.lblTaiKhoan.Text = "Tài Khoản";
			// 
			// lblMatKhau
			// 
			this.lblMatKhau.AutoSize = true;
			this.lblMatKhau.Location = new System.Drawing.Point(177, 150);
			this.lblMatKhau.Name = "lblMatKhau";
			this.lblMatKhau.Size = new System.Drawing.Size(62, 16);
			this.lblMatKhau.TabIndex = 3;
			this.lblMatKhau.Text = "Mật Khẩu";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Location = new System.Drawing.Point(180, 264);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(201, 71);
			this.btnDangNhap.TabIndex = 4;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "student",
            "teacher"});
			this.comboBox1.Location = new System.Drawing.Point(180, 217);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(201, 24);
			this.comboBox1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 441);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.lblMatKhau);
			this.Controls.Add(this.lblTaiKhoan);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTaiKhoan);
			this.Name = "Form1";
			this.Text = "Form_DangNhap";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label lblTaiKhoan;
		private System.Windows.Forms.Label lblMatKhau;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

