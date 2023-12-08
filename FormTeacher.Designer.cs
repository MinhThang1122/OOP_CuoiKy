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
            this.dataGridViewHS.Location = new System.Drawing.Point(760, 351);
            this.dataGridViewHS.Name = "dataGridViewHS";
            this.dataGridViewHS.RowHeadersWidth = 51;
            this.dataGridViewHS.RowTemplate.Height = 24;
            this.dataGridViewHS.Size = new System.Drawing.Size(628, 153);
            this.dataGridViewHS.TabIndex = 17;
            // 
            // dataGridViewKQ
            // 
            this.dataGridViewKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKQ.Location = new System.Drawing.Point(760, 55);
            this.dataGridViewKQ.Name = "dataGridViewKQ";
            this.dataGridViewKQ.RowHeadersWidth = 51;
            this.dataGridViewKQ.RowTemplate.Height = 24;
            this.dataGridViewKQ.Size = new System.Drawing.Size(628, 283);
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
            this.panel2.Location = new System.Drawing.Point(208, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 160);
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
            this.btnTimKiem.Location = new System.Drawing.Point(18, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(124, 54);
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
            this.lblTenHS.Location = new System.Drawing.Point(254, 57);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(88, 16);
            this.lblTenHS.TabIndex = 1;
            this.lblTenHS.Text = "Tên Học Sinh";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(35, 56);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(83, 16);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã Học Sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtMaDethi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNoiDung);
            this.panel1.Controls.Add(this.txtMaChuong);
            this.panel1.Controls.Add(this.lblND);
            this.panel1.Controls.Add(this.txtMaCauHoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(208, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 283);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThemCH);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Location = new System.Drawing.Point(31, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 53);
            this.panel3.TabIndex = 8;
            // 
            // btnThemCH
            // 
            this.btnThemCH.Location = new System.Drawing.Point(14, 17);
            this.btnThemCH.Name = "btnThemCH";
            this.btnThemCH.Size = new System.Drawing.Size(75, 23);
            this.btnThemCH.TabIndex = 7;
            this.btnThemCH.Text = "Thêm";
            this.btnThemCH.UseVisualStyleBackColor = true;
            this.btnThemCH.Click += new System.EventHandler(this.btnThemCH_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(333, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(172, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaDethi
            // 
            this.txtMaDethi.Location = new System.Drawing.Point(342, 52);
            this.txtMaDethi.Multiline = true;
            this.txtMaDethi.Name = "txtMaDethi";
            this.txtMaDethi.Size = new System.Drawing.Size(112, 19);
            this.txtMaDethi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Đề Thi";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(109, 80);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(345, 131);
            this.txtNoiDung.TabIndex = 1;
            // 
            // txtMaChuong
            // 
            this.txtMaChuong.Location = new System.Drawing.Point(109, 55);
            this.txtMaChuong.Multiline = true;
            this.txtMaChuong.Name = "txtMaChuong";
            this.txtMaChuong.Size = new System.Drawing.Size(112, 19);
            this.txtMaChuong.TabIndex = 5;
            // 
            // lblND
            // 
            this.lblND.AutoSize = true;
            this.lblND.Location = new System.Drawing.Point(28, 83);
            this.lblND.Name = "lblND";
            this.lblND.Size = new System.Drawing.Size(66, 32);
            this.lblND.TabIndex = 0;
            this.lblND.Text = "Nội Dung \r\nCâu Hỏi";
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Location = new System.Drawing.Point(109, 30);
            this.txtMaCauHoi.Multiline = true;
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(112, 19);
            this.txtMaCauHoi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Câu Hỏi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Chương";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 558);
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
    }
}