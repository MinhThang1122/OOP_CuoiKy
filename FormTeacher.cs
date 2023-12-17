﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        CuoiKy_OOPEntities4 db = new CuoiKy_OOPEntities4();
        List<CauHoi> dsCauHoi = new List<CauHoi>();
        List<HocVien> dsHocVien = new List<HocVien>();
        C_User User = null;
        CauHoi cauHoi = null;
        private void FormTeacher_Load(object sender, EventArgs e)
        {

        }
		void loadCauHoi(List<CauHoi> x)
		{
			dataGridViewKQ.Columns.Add("MaCauHoi", "Ma Cau Hoi");
			dataGridViewKQ.Columns.Add("MaChuong", "Ma Chuong");
			dataGridViewKQ.Columns.Add("MaMonHoc", "Ma Mon Hoc");
			dataGridViewKQ.Columns.Add("NoiDung", "Noi Dung");
			foreach (CauHoi CH in x )
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dataGridViewKQ);
				row.Cells[0].Value = CH.MaCauHoi + "";
				row.Cells[1].Value = CH.MaChuong + "";

				

				dataGridViewKQ.Columns[3].Width = 150;
				row.Cells[3].Value = CH.HinhAnhCauHoi;
				dataGridViewKQ.Rows.Add(row);
			}
		}
		void loadhs(List<HocVien> y)
		{
			dataGridViewHS.Columns.Add("MaHocVien", "Ma Hoc Vien");
			dataGridViewHS.Columns.Add("TenHocVien", "Ten Hoc Vien");
			dataGridViewHS.Columns.Add("DiaChi", "Dia Chi");
			dataGridViewHS.Columns.Add("MaUser", "Ma User");
			foreach (HocVien HV in y)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dataGridViewHS);
				row.Cells[0].Value = HV.MaHocVien + "";
				row.Cells[1].Value = HV.HoTen;
				row.Cells[2].Value = HV.DiaChi + "";
				row.Cells[3].Value = HV.MaUser + "";
				dataGridViewHS.Rows.Add(row);
			}
		}
		private void btnThemCH_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaCauHoi.Text) || string.IsNullOrWhiteSpace(txtMaCauHoi.Text)) return;
			
			string macauhoi = txtMaCauHoi.Text;
			string machuong = txtMaChuong.Text;
			string madethi = txtMaMon.Text;
			string mamonhoc = txtMaMon.Text;

			List<CauHoi> cauhoi = dsCauHoi.Where(t => t.MaCauHoi == macauhoi).ToList();

			if (cauhoi.Count > 0)
			{
				MessageBox.Show("Cau hoi nay bi trung");
				return;
			}

			cauHoi = new CauHoi();
			cauHoi.MaCauHoi = macauhoi;
			cauHoi.MaChuong = machuong;
			
			

			MessageBox.Show("Them cau hoi thanh cong");

			dsCauHoi.Add(cauHoi);

			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dataGridViewKQ);
			row.Cells[0].Value = macauhoi;
			row.Cells[1].Value = machuong;
			row.Cells[2].Value = madethi;
			
            row.Cells[4].Value = file;
            dataGridViewKQ.Rows.Add(row);

			db.CauHois.Add(cauHoi);
			db.SaveChanges();
		}


		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (cauHoi == null) return;

			//xoa trong csdl
			db.CauHois.Remove(cauHoi);
			//xoa trong dsls
			dsCauHoi.Remove(cauHoi);
			//xoa trong luoi
			dataGridViewKQ.Rows.Remove(dataGridViewKQ.CurrentRow);
			//thiet lap lai gia tri ban dau cho cau hoi
			cauHoi = null;
			MessageBox.Show("Xoa thanh cong");
			db.SaveChanges();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			SqlDataAdapter da;
			SqlConnection conn = new SqlConnection("Data Source=DESKTOP-APT8J1L;Initial Catalog=CuoiKy_OOP;Integrated Security=True");
			da = new SqlDataAdapter("Select * From HocVien where MaHocVien = " + txtMaHS.Text, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			da.Dispose();
			dataGridViewHS.DataSource = dt;
		}

		private void FormTeacher_Load_1(object sender, EventArgs e)
		{
			//lay ds loai sach
			dsCauHoi = db.CauHois.ToList();

			//hien thi len datagird
			loadCauHoi(dsCauHoi);
		}

		private void dtaGridViewKQ_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dataGridViewKQ.CurrentRow;
			int index = row.Index;
			if (index >= dsCauHoi.Count)
				return;
			//hien thi thong tin tren cac txt
			cauHoi = dsCauHoi[index];
			txtMaCauHoi.Text = cauHoi.MaCauHoi + "";
			txtMaChuong.Text = cauHoi.MaChuong;
			txtMaMon.Text = cauHoi.MaCauHoi;
			
		}


		Image file;
		private void picboxNDcauHoi_Click(object sender, EventArgs e)
		{
			OpenFileDialog f = new OpenFileDialog();
			f.Filter = "JPG (*.JPG)|*.jpg";
			if (f.ShowDialog() == DialogResult.OK)
			{
                file = Image.FromFile(f.FileName);
				picboxNDcauHoi.Image = file;
			}
            picboxNDcauHoi.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cauHoi == null) return;
            string macauhoi = txtMaCauHoi.Text;
            string machuong = txtMaChuong.Text;
            string mamon = txtMaMon.Text;
			
            

            cauHoi.MaCauHoi = txtMaCauHoi.Text;
            cauHoi.MaChuong = txtMaChuong.Text;

            db.SaveChanges();

            //cap nhat len luoi
            int index = dataGridViewKQ.CurrentRow.Index;
            dataGridViewKQ.Rows[index].Cells[1].Value = macauhoi;
            dataGridViewKQ.Rows[index].Cells[2].Value = machuong;
            dataGridViewKQ.Rows[index].Cells[3].Value = mamon;
			dataGridViewKQ.Rows[index].Cells[4].Value = file;
			MessageBox.Show("Sua thanh cong");
        }
    }
}


