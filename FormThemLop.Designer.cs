namespace DoAn_CuoiKy
{
	partial class FormThemLop
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.dtaGridViewLop = new System.Windows.Forms.DataGridView();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridViewLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(400, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 50);
            this.label3.TabIndex = 30;
            this.label3.Text = "DANH SÁCH LỚP\r\n\r\n\r\n\r\n\r\n";
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.DarkViolet;
            this.btnThemLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(305, 327);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(85, 47);
            this.btnThemLop.TabIndex = 18;
            this.btnThemLop.Text = "Them";
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.DarkViolet;
            this.btnXoaLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(493, 327);
            this.btnXoaLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(85, 47);
            this.btnXoaLop.TabIndex = 19;
            this.btnXoaLop.Text = "Xoa";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // dtaGridViewLop
            // 
            this.dtaGridViewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridViewLop.Location = new System.Drawing.Point(131, 417);
            this.dtaGridViewLop.Name = "dtaGridViewLop";
            this.dtaGridViewLop.RowHeadersWidth = 51;
            this.dtaGridViewLop.RowTemplate.Height = 24;
            this.dtaGridViewLop.Size = new System.Drawing.Size(944, 304);
            this.dtaGridViewLop.TabIndex = 27;
            this.dtaGridViewLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridViewLop_CellClick);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(241, 199);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(210, 22);
            this.txtMaLop.TabIndex = 22;
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSuaLop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLop.ForeColor = System.Drawing.Color.White;
            this.btnSuaLop.Location = new System.Drawing.Point(685, 327);
            this.btnSuaLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(85, 47);
            this.btnSuaLop.TabIndex = 24;
            this.btnSuaLop.Text = "Sua";
            this.btnSuaLop.UseVisualStyleBackColor = false;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl10.Location = new System.Drawing.Point(128, 251);
            this.lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(57, 16);
            this.lbl10.TabIndex = 21;
            this.lbl10.Text = "Tên Lớp";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl.Location = new System.Drawing.Point(148, 205);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 16);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "Mã Lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(241, 245);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(210, 22);
            this.txtTenLop.TabIndex = 23;
            // 
            // FormThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 756);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.dtaGridViewLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.btnSuaLop);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtTenLop);
            this.Name = "FormThemLop";
            this.Text = "FormThemLop";
            this.Load += new System.EventHandler(this.FormThemLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridViewLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnThemLop;
		private System.Windows.Forms.Button btnXoaLop;
		private System.Windows.Forms.DataGridView dtaGridViewLop;
		private System.Windows.Forms.TextBox txtMaLop;
		private System.Windows.Forms.Button btnSuaLop;
		private System.Windows.Forms.Label lbl10;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txtTenLop;
	}
}