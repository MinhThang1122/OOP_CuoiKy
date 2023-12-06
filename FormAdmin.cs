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
	public partial class FormAdmin : Form
	{
		QuanLyThiTracNgiemEntities1 db = new QuanLyThiTracNgiemEntities1();
		List<C_User> dsUser	= new List<C_User>();
		List<HocVien> dsHocVien = new List<HocVien>();
		List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
		C_User User = null;
		HocVien hocVien = null;
		GiaoVien giaoVien = null;

		public FormAdmin()
		{
			InitializeComponent();
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

		private void FormAdmin_Load(object sender, EventArgs e)
		{
			
		}

		private void themTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormThemTkUser f = new FormThemTkUser();
			AddForm(f);
		}

		private void themThongTinUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormThemTTHocVien f = new FormThemTTHocVien();
			AddForm(f);
		}

		private void themThongTinGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormThemTTGiaoVien f = new FormThemTTGiaoVien();
			AddForm(f);
		}
	}
}
