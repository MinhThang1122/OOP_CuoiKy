using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
	public partial class FormThongTinStudent : Form
	{
        CuoiKy_OOPEntities4 db = new CuoiKy_OOPEntities4();
        List<HocVien> dsHocVien = new List<HocVien>();
		List<LopHoc> dsLopHoc = new List<LopHoc>();
		List<MonHoc> dsMonHoc = new List<MonHoc>();
		
        public FormThongTinStudent()
		{
			InitializeComponent();
		}


        private void btnThi_Click(object sender, EventArgs e)
		{
			FormThi f = new FormThi();
			f.ShowDialog();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}

        private void FormThongTinStudent_Load(object sender, EventArgs e)
        {
			
			dsHocVien = db.HocViens.ToList();

			

			List<HocVien> hocvien = dsHocVien.Where(t => t.MaUser == mauser).ToList();

            txtMaHocVien.Text = dsHocVien[1].MaHocVien;
			txtHoTenHV.Text = dsHocVien[1].HoTen;

			txtMaLop.Text = dsLopHoc[2].TenLopHoc;
			lboxMonHoc.Text = dsMonHoc[1].TenMonHoc;
        }
		

        private void txtMaHocVien_TextChanged(object sender, EventArgs e)
        {
			
        }
    }
}
