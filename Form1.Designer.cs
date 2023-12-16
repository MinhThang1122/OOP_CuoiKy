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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.lblTaiKhoan = new System.Windows.Forms.Label();
			this.lblMatKhau = new System.Windows.Forms.Label();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Location = new System.Drawing.Point(180, 219);
			this.txtTaiKhoan.Multiline = true;
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(248, 25);
			this.txtTaiKhoan.TabIndex = 0;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(179, 305);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(248, 29);
			this.txtMatKhau.TabIndex = 1;
			// 
			// lblTaiKhoan
			// 
			this.lblTaiKhoan.AutoSize = true;
			this.lblTaiKhoan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaiKhoan.ForeColor = System.Drawing.Color.DarkViolet;
			this.lblTaiKhoan.Location = new System.Drawing.Point(176, 195);
			this.lblTaiKhoan.Name = "lblTaiKhoan";
			this.lblTaiKhoan.Size = new System.Drawing.Size(95, 21);
			this.lblTaiKhoan.TabIndex = 2;
			this.lblTaiKhoan.Text = "Tài Khoản";
			// 
			// lblMatKhau
			// 
			this.lblMatKhau.AutoSize = true;
			this.lblMatKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatKhau.ForeColor = System.Drawing.Color.DarkViolet;
			this.lblMatKhau.Location = new System.Drawing.Point(176, 281);
			this.lblMatKhau.Name = "lblMatKhau";
			this.lblMatKhau.Size = new System.Drawing.Size(91, 21);
			this.lblMatKhau.TabIndex = 3;
			this.lblMatKhau.Text = "Mật Khẩu";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.Color.DarkViolet;
			this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.ForeColor = System.Drawing.Color.White;
			this.btnDangNhap.Location = new System.Drawing.Point(179, 438);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(248, 71);
			this.btnDangNhap.TabIndex = 4;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "student",
            "teacher"});
			this.comboBox1.Location = new System.Drawing.Point(179, 382);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(248, 24);
			this.comboBox1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.btnDangNhap);
			this.panel2.Controls.Add(this.txtTaiKhoan);
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.txtMatKhau);
			this.panel2.Controls.Add(this.lblTaiKhoan);
			this.panel2.Controls.Add(this.lblMatKhau);
			this.panel2.Location = new System.Drawing.Point(742, 66);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(582, 614);
			this.panel2.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkViolet;
			this.label1.Location = new System.Drawing.Point(190, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 46);
			this.label1.TabIndex = 6;
			this.label1.Text = "Welcome !";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(125, 66);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(619, 614);
			this.panel1.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.DarkViolet;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1451, 767);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form_DangNhap";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label lblTaiKhoan;
		private System.Windows.Forms.Label lblMatKhau;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
	}
}

