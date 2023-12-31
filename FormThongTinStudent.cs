﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity;
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
        CuoiKy_OOPEntities9 db = new CuoiKy_OOPEntities9();
        List<HocVien> dsHocVien = new List<HocVien>();
		List<LopHoc> dsLopHoc = new List<LopHoc>();
		List<MonHoc> dsMonHoc = new List<MonHoc>();
		HocVien hocVien = null;
        MonHoc monHoc = null;
        
		
        public FormThongTinStudent()
		{
			InitializeComponent();
		}


        private void btnThi_Click(object sender, EventArgs e)
		{
            dsMonHoc = db.MonHocs.ToList();
            string tenmonhoc = comboBox1.SelectedIndex.ToString();
			FormThi f = new FormThi();
            if (comboBox1.SelectedIndex == 0)
            {
                f.ShowDialog();
            }
			
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

            //string mauser = string.Empty;
            //List<HocVien> hocVien = dsHocVien.Where(t => t.MaUser == mauser).ToList();
            for (int i = 0; i < dsHocVien.Count; i++)
            {
                if (dsHocVien[i] != null)
                {
                    txtHoTenHV.Text = dsHocVien[i].HoTen;
                    txtMaHocVien.Text = dsHocVien[i].MaHocVien;
                    txtMaLop.Text = dsHocVien[i].MaLopHoc;
                    MemoryStream ms = new MemoryStream(dsHocVien[i].HinhAnh);
                    picBoxHocVien.Image = Image.FromStream(ms);
                    picBoxHocVien.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }
		

        private void txtMaHocVien_TextChanged(object sender, EventArgs e)
        {
			
        }

        private void gbProfile_Enter(object sender, EventArgs e)
        {

        }
    }
}
