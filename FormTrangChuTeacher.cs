using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class FormTrangChuTeacher : Form
    {
        public FormTrangChuTeacher()
        {
            InitializeComponent();
        }

        private void FormTrangChuTeacher_Load(object sender, EventArgs e)
        {

        }
        private void AddForm(Form form)
        {
            this.panel1.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            form.Show();
        }
        private void thêmCâuHỏiVàTìmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeacher f = new FormTeacher();
            AddForm(f);
        }

        private void thêmĐềThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemDeThi f = new FormThemDeThi();
            AddForm(f);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
