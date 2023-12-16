namespace DoAn_CuoiKy
{
	partial class FormTeacher
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
			this.dataGridViewHS = new System.Windows.Forms.DataGridView();
			this.dataGridViewKQ = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtMaHS = new System.Windows.Forms.TextBox();
			this.txtTenHS = new System.Windows.Forms.TextBox();
			this.lblTenHS = new System.Windows.Forms.Label();
			this.lblMaHS = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtDapAnDung = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnThemCH = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.txtMaDethi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNoiDung = new System.Windows.Forms.TextBox();
			this.txtMaChuong = new System.Windows.Forms.TextBox();
			this.lblND = new System.Windows.Forms.Label();
			this.txtMaCauHoi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKQ)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewHS
			// 
			this.dataGridViewHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHS.Location = new System.Drawing.Point(656, 468);
			this.dataGridViewHS.Name = "dataGridViewHS";
			this.dataGridViewHS.RowHeadersWidth = 51;
			this.dataGridViewHS.RowTemplate.Height = 24;
			this.dataGridViewHS.Size = new System.Drawing.Size(628, 178);
			this.dataGridViewHS.TabIndex = 17;
			// 
			// dataGridViewKQ
			// 
			this.dataGridViewKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKQ.Location = new System.Drawing.Point(656, 126);
			this.dataGridViewKQ.Name = "dataGridViewKQ";
			this.dataGridViewKQ.RowHeadersWidth = 51;
			this.dataGridViewKQ.RowTemplate.Height = 24;
			this.dataGridViewKQ.Size = new System.Drawing.Size(628, 311);
			this.dataGridViewKQ.TabIndex = 16;
			this.dataGridViewKQ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridViewKQ_CellClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.txtMaHS);
			this.panel2.Controls.Add(this.txtTenHS);
			this.panel2.Controls.Add(this.lblTenHS);
			this.panel2.Controls.Add(this.lblMaHS);
			this.panel2.Location = new System.Drawing.Point(104, 468);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(504, 178);
			this.panel2.TabIndex = 15;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.btnTimKiem);
			this.panel4.Location = new System.Drawing.Point(184, 103);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(115, 33);
			this.panel4.TabIndex = 12;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.DarkViolet;
			this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Location = new System.Drawing.Point(18, 3);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 12;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtMaHS
			// 
			this.txtMaHS.Location = new System.Drawing.Point(126, 51);
			this.txtMaHS.Name = "txtMaHS";
			this.txtMaHS.Size = new System.Drawing.Size(100, 22);
			this.txtMaHS.TabIndex = 3;
			// 
			// txtTenHS
			// 
			this.txtTenHS.Location = new System.Drawing.Point(354, 54);
			this.txtTenHS.Name = "txtTenHS";
			this.txtTenHS.Size = new System.Drawing.Size(100, 22);
			this.txtTenHS.TabIndex = 4;
			// 
			// lblTenHS
			// 
			this.lblTenHS.AutoSize = true;
			this.lblTenHS.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenHS.ForeColor = System.Drawing.Color.DarkViolet;
			this.lblTenHS.Location = new System.Drawing.Point(254, 57);
			this.lblTenHS.Name = "lblTenHS";
			this.lblTenHS.Size = new System.Drawing.Size(89, 16);
			this.lblTenHS.TabIndex = 1;
			this.lblTenHS.Text = "Tên Học Sinh";
			// 
			// lblMaHS
			// 
			this.lblMaHS.AutoSize = true;
			this.lblMaHS.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaHS.ForeColor = System.Drawing.Color.DarkViolet;
			this.lblMaHS.Location = new System.Drawing.Point(33, 57);
			this.lblMaHS.Name = "lblMaHS";
			this.lblMaHS.Size = new System.Drawing.Size(85, 16);
			this.lblMaHS.TabIndex = 0;
			this.lblMaHS.Text = "Mã Học Sinh";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtDapAnDung);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.txtMaDethi);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtNoiDung);
			this.panel1.Controls.Add(this.txtMaChuong);
			this.panel1.Controls.Add(this.lblND);
			this.panel1.Controls.Add(this.txtMaCauHoi);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(104, 126);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 311);
			this.panel1.TabIndex = 14;
			// 
			// txtDapAnDung
			// 
			this.txtDapAnDung.Location = new System.Drawing.Point(357, 27);
			this.txtDapAnDung.Multiline = true;
			this.txtDapAnDung.Name = "txtDapAnDung";
			this.txtDapAnDung.Size = new System.Drawing.Size(112, 19);
			this.txtDapAnDung.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkViolet;
			this.label1.Location = new System.Drawing.Point(259, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Đáp Án Đúng";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnThemCH);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Location = new System.Drawing.Point(31, 235);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(423, 59);
			this.panel3.TabIndex = 8;
			// 
			// btnThemCH
			// 
			this.btnThemCH.BackColor = System.Drawing.Color.DarkViolet;
			this.btnThemCH.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemCH.ForeColor = System.Drawing.Color.White;
			this.btnThemCH.Location = new System.Drawing.Point(12, 10);
			this.btnThemCH.Name = "btnThemCH";
			this.btnThemCH.Size = new System.Drawing.Size(75, 37);
			this.btnThemCH.TabIndex = 7;
			this.btnThemCH.Text = "Thêm";
			this.btnThemCH.UseVisualStyleBackColor = false;
			this.btnThemCH.Click += new System.EventHandler(this.btnThemCH_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.DarkViolet;
			this.btnSua.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Location = new System.Drawing.Point(323, 10);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 37);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.DarkViolet;
			this.btnXoa.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(163, 10);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 37);
			this.btnXoa.TabIndex = 8;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// txtMaDethi
			// 
			this.txtMaDethi.Location = new System.Drawing.Point(354, 52);
			this.txtMaDethi.Multiline = true;
			this.txtMaDethi.Name = "txtMaDethi";
			this.txtMaDethi.Size = new System.Drawing.Size(112, 19);
			this.txtMaDethi.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkViolet;
			this.label4.Location = new System.Drawing.Point(259, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Mã Đề Thi";
			// 
			// txtNoiDung
			// 
			this.txtNoiDung.Location = new System.Drawing.Point(124, 80);
			this.txtNoiDung.Multiline = true;
			this.txtNoiDung.Name = "txtNoiDung";
			this.txtNoiDung.Size = new System.Drawing.Size(345, 131);
			this.txtNoiDung.TabIndex = 1;
			// 
			// txtMaChuong
			// 
			this.txtMaChuong.Location = new System.Drawing.Point(124, 55);
			this.txtMaChuong.Multiline = true;
			this.txtMaChuong.Name = "txtMaChuong";
			this.txtMaChuong.Size = new System.Drawing.Size(112, 19);
			this.txtMaChuong.TabIndex = 5;
			// 
			// lblND
			// 
			this.lblND.AutoSize = true;
			this.lblND.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblND.ForeColor = System.Drawing.Color.DarkViolet;
			this.lblND.Location = new System.Drawing.Point(28, 83);
			this.lblND.Name = "lblND";
			this.lblND.Size = new System.Drawing.Size(67, 32);
			this.lblND.TabIndex = 0;
			this.lblND.Text = "Nội Dung \r\nCâu Hỏi";
			// 
			// txtMaCauHoi
			// 
			this.txtMaCauHoi.Location = new System.Drawing.Point(124, 30);
			this.txtMaCauHoi.Multiline = true;
			this.txtMaCauHoi.Name = "txtMaCauHoi";
			this.txtMaCauHoi.Size = new System.Drawing.Size(112, 19);
			this.txtMaCauHoi.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkViolet;
			this.label2.Location = new System.Drawing.Point(26, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mã Câu Hỏi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkViolet;
			this.label3.Location = new System.Drawing.Point(28, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mã Chương";
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.DarkViolet;
			this.btnLogout.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Location = new System.Drawing.Point(1209, 43);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(75, 37);
			this.btnLogout.TabIndex = 10;
			this.btnLogout.Text = "Thoát";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// FormTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1405, 748);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.dataGridViewHS);
			this.Controls.Add(this.dataGridViewKQ);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormTeacher";
			this.Text = "FormTeacher";
			this.Load += new System.EventHandler(this.FormTeacher_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKQ)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHS;
        private System.Windows.Forms.DataGridView dataGridViewKQ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThemCH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaDethi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtMaChuong;
        private System.Windows.Forms.Label lblND;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDapAnDung;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLogout;
	}
}