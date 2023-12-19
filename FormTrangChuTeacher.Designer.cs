namespace DoAn_CuoiKy
{
    partial class FormTrangChuTeacher
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
            this.thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmĐềThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem,
            this.thêmĐềThiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem
            // 
            this.thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem.Name = "thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem";
            this.thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem.Text = "Thêm Câu Hỏi và Tìm học Sinh";
            this.thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem_Click);
            // 
            // thêmĐềThiToolStripMenuItem
            // 
            this.thêmĐềThiToolStripMenuItem.Name = "thêmĐềThiToolStripMenuItem";
            this.thêmĐềThiToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.thêmĐềThiToolStripMenuItem.Text = "Thêm Đề Thi";
            this.thêmĐềThiToolStripMenuItem.Click += new System.EventHandler(this.thêmĐềThiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 485);
            this.panel1.TabIndex = 1;
            // 
            // FormTrangChuTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrangChuTeacher";
            this.Text = "FormTrangChuTeacher";
            this.Load += new System.EventHandler(this.FormTrangChuTeacher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmĐềThiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}