﻿using System;
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
	public partial class FormThemTkUser : Form
	{
		QuanLyThiTracNgiemEntities1 db = new QuanLyThiTracNgiemEntities1();
		List<C_User> dsUser = new List<C_User>();
		List<HocVien> dsHocVien = new List<HocVien>();
		List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
		C_User User = null;

		public FormThemTkUser()
		{
			InitializeComponent();
		}

		private void FormThemTkUser_Load(object sender, EventArgs e)
		{
			//lay ds loai sach
			dsUser = db.C_User.ToList();

			//hien thi len datagird
			loadDataUser(dsUser);
		}

		void loadDataUser(List<C_User> x)
		{
			dtaGridViewAdmin.Columns.Add("MaUser", "Ma User");
			dtaGridViewAdmin.Columns.Add("UserRoles", "User Roles");
			dtaGridViewAdmin.Columns.Add("TenDN", "Ten Dang Nhap");
			dtaGridViewAdmin.Columns.Add("MK", "Mat Khau");

			foreach (C_User a in x)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dtaGridViewAdmin);
				row.Cells[0].Value = a.MaUser + "";
				row.Cells[1].Value = a.UserRoles;
				row.Cells[2].Value = a.TenDN + "";
				row.Cells[3].Value = a.MK;
				dtaGridViewAdmin.Rows.Add(row);
			}
		}

		private void btnThemTaiKhoan_Click(object sender, EventArgs e)
		{
			//kiem tra xem da co user muon them vao hay chua
			if (string.IsNullOrEmpty(txtMaUser.Text) || string.IsNullOrWhiteSpace(txtMaUser.Text)) return;
			if (string.IsNullOrEmpty(txtRoles.Text) || string.IsNullOrWhiteSpace(txtRoles.Text)) return;
			if (string.IsNullOrEmpty(txtTenDN.Text) || string.IsNullOrWhiteSpace(txtTenDN.Text)) return;
			if (string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text)) return;

			//kiem tra xem co du lieu hay chua
			string maUser = txtMaUser.Text;
			string taiKhoan = txtTenDN.Text;
			string matKhau = txtMatKhau.Text;
			string roles = txtRoles.Text;

			List<C_User> list = dsUser.Where(t => t.MaUser == maUser || t.TenDN == taiKhoan).ToList();

			if (list.Count > 0)
			{
				MessageBox.Show("User nay da co vui long kiem tra lai");
				return;
			}

			//xu ly them
			User = new C_User();
			User.MaUser = maUser;
			User.UserRoles = roles;
			User.TenDN = taiKhoan;
			User.MK = matKhau;

			MessageBox.Show("Them thanh cong");

			//them vao dsls
			dsUser.Add(User);

			//them vao dtagridview
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dtaGridViewAdmin);
			row.Cells[0].Value = maUser;
			row.Cells[1].Value = roles;
			row.Cells[2].Value = taiKhoan;
			row.Cells[3].Value = matKhau;
			dtaGridViewAdmin.Rows.Add(row);

			//them vao csdl
			db.C_User.Add(User);
			db.SaveChanges();
		}

		private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
		{
			if (User == null) return;

			//xoa trong csdl
			db.C_User.Remove(User);
			//xoa trong dsls
			dsUser.Remove(User);
			//xoa trong luoi
			dtaGridViewAdmin.Rows.Remove(dtaGridViewAdmin.CurrentRow);
			//thiet lap lai gia tri ban dau cho hoc vien
			User = null;
			MessageBox.Show("Xoa thanh cong");
			db.SaveChanges();
		}

		private void dtaGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dtaGridViewAdmin.CurrentRow;
			int index = row.Index;
			if (index >= dsUser.Count)
				return;
			//hien thi thong tin tren cac txt
			User = dsUser[index];
			txtMaUser.Text = User.MaUser + "";
			txtTenDN.Text = User.TenDN;
			txtMatKhau.Text = User.MK;
			txtRoles.Text = User.UserRoles;

		}
	}
}