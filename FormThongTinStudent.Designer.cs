namespace DoAn_CuoiKy
{
	partial class FormThongTinStudent
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
            this.gbLuyenThi = new System.Windows.Forms.GroupBox();
            this.btnThi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.picBoxHocVien = new System.Windows.Forms.PictureBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtHoTenHV = new System.Windows.Forms.TextBox();
            this.txtMaHocVien = new System.Windows.Forms.TextBox();
            this.lboxMonHoc = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaHV = new System.Windows.Forms.Label();
            this.gbLuyenThi.SuspendLayout();
            this.gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLuyenThi
            // 
            this.gbLuyenThi.Controls.Add(this.btnThi);
            this.gbLuyenThi.Controls.Add(this.comboBox1);
            this.gbLuyenThi.Controls.Add(this.label1);
            this.gbLuyenThi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuyenThi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbLuyenThi.Location = new System.Drawing.Point(278, 188);
            this.gbLuyenThi.Name = "gbLuyenThi";
            this.gbLuyenThi.Size = new System.Drawing.Size(328, 153);
            this.gbLuyenThi.TabIndex = 6;
            this.gbLuyenThi.TabStop = false;
            this.gbLuyenThi.Text = "Luyện thi";
            // 
            // btnThi
            // 
            this.btnThi.BackColor = System.Drawing.Color.DarkViolet;
            this.btnThi.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThi.ForeColor = System.Drawing.Color.White;
            this.btnThi.Location = new System.Drawing.Point(87, 96);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(121, 40);
            this.btnThi.TabIndex = 6;
            this.btnThi.Text = "Bắt đầu thi";
            this.btnThi.UseVisualStyleBackColor = false;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toán",
            "Anh"});
            this.comboBox1.Location = new System.Drawing.Point(87, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Môn thi:";
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.picBoxHocVien);
            this.gbProfile.Controls.Add(this.txtMaLop);
            this.gbProfile.Controls.Add(this.txtHoTenHV);
            this.gbProfile.Controls.Add(this.txtMaHocVien);
            this.gbProfile.Controls.Add(this.lboxMonHoc);
            this.gbProfile.Controls.Add(this.flowLayoutPanel1);
            this.gbProfile.Controls.Add(this.lblMonHoc);
            this.gbProfile.Controls.Add(this.lblMaLop);
            this.gbProfile.Controls.Add(this.lblHoTen);
            this.gbProfile.Controls.Add(this.lblMaHV);
            this.gbProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbProfile.Location = new System.Drawing.Point(691, 188);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(343, 373);
            this.gbProfile.TabIndex = 5;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Thông tin cá nhân";
            this.gbProfile.Enter += new System.EventHandler(this.gbProfile_Enter);
            // 
            // picBoxHocVien
            // 
            this.picBoxHocVien.BackColor = System.Drawing.Color.White;
            this.picBoxHocVien.Location = new System.Drawing.Point(245, 21);
            this.picBoxHocVien.Name = "picBoxHocVien";
            this.picBoxHocVien.Size = new System.Drawing.Size(86, 115);
            this.picBoxHocVien.TabIndex = 12;
            this.picBoxHocVien.TabStop = false;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(120, 189);
            this.txtMaLop.Multiline = true;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(122, 20);
            this.txtMaLop.TabIndex = 11;
            // 
            // txtHoTenHV
            // 
            this.txtHoTenHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenHV.Location = new System.Drawing.Point(120, 160);
            this.txtHoTenHV.Multiline = true;
            this.txtHoTenHV.Name = "txtHoTenHV";
            this.txtHoTenHV.ReadOnly = true;
            this.txtHoTenHV.Size = new System.Drawing.Size(122, 20);
            this.txtHoTenHV.TabIndex = 10;
            // 
            // txtMaHocVien
            // 
            this.txtMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocVien.Location = new System.Drawing.Point(120, 133);
            this.txtMaHocVien.Multiline = true;
            this.txtMaHocVien.Name = "txtMaHocVien";
            this.txtMaHocVien.ReadOnly = true;
            this.txtMaHocVien.Size = new System.Drawing.Size(122, 20);
            this.txtMaHocVien.TabIndex = 9;
            this.txtMaHocVien.TextChanged += new System.EventHandler(this.txtMaHocVien_TextChanged);
            // 
            // lboxMonHoc
            // 
            this.lboxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxMonHoc.FormattingEnabled = true;
            this.lboxMonHoc.ItemHeight = 16;
            this.lboxMonHoc.Location = new System.Drawing.Point(103, 235);
            this.lboxMonHoc.Name = "lboxMonHoc";
            this.lboxMonHoc.Size = new System.Drawing.Size(228, 84);
            this.lboxMonHoc.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(261, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(25, 235);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(66, 16);
            this.lblMonHoc.TabIndex = 5;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(25, 193);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(54, 16);
            this.lblMaLop.TabIndex = 5;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(27, 164);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(55, 16);
            this.lblHoTen.TabIndex = 5;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaHV
            // 
            this.lblMaHV.AutoSize = true;
            this.lblMaHV.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHV.Location = new System.Drawing.Point(25, 137);
            this.lblMaHV.Name = "lblMaHV";
            this.lblMaHV.Size = new System.Drawing.Size(89, 16);
            this.lblMaHV.TabIndex = 4;
            this.lblMaHV.Text = "Mã học viên:";
            // 
            // FormThongTinStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 748);
            this.Controls.Add(this.gbLuyenThi);
            this.Controls.Add(this.gbProfile);
            this.Name = "FormThongTinStudent";
            this.Text = "FormThongTinStudent";
            this.Load += new System.EventHandler(this.FormThongTinStudent_Load);
            this.gbLuyenThi.ResumeLayout(false);
            this.gbLuyenThi.PerformLayout();
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHocVien)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbLuyenThi;
		private System.Windows.Forms.Button btnThi;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbProfile;
		private System.Windows.Forms.TextBox txtMaLop;
		private System.Windows.Forms.TextBox txtHoTenHV;
		private System.Windows.Forms.TextBox txtMaHocVien;
		private System.Windows.Forms.ListBox lboxMonHoc;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblMonHoc;
		private System.Windows.Forms.Label lblMaLop;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.PictureBox picBoxHocVien;
    }
}