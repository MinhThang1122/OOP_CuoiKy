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
	public partial class FormStudent : Form
	{
		CuoiKy_OOPEntities1 db = new CuoiKy_OOPEntities1();
		List<C_User> dsUser = new List<C_User>();
		List<HocVien> dsHocVien = new List<HocVien>();
		List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
		C_User User = null;
		HocVien hocVien = null;
		GiaoVien giaoVien = null;

		public FormStudent()
		{
			InitializeComponent();
		}

        private void FormStudent_Load(object sender, EventArgs e)
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

		private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormThongTinStudent f = new FormThongTinStudent();
			AddForm(f);
		}

		private void thiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormTraCuuKQStudent f = new FormTraCuuKQStudent();
			AddForm(f);
		}
	}
}
