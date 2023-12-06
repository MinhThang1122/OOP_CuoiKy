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
        CuoiKy_OOPEntities db = new CuoiKy_OOPEntities();
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

		private void rdHocVien_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void rdGiaoVien_CheckedChanged(object sender, EventArgs e)
		{
			
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

		void loadDataTTStudent(List<HocVien> y)
		{
			dtaGridViewTTHocVien.Columns.Add("MaHocVien", "Ma Hoc Vien");
			dtaGridViewTTHocVien.Columns.Add("HoTen", "Ho Ten");
			dtaGridViewTTHocVien.Columns.Add("DiaChi", "Dia Chi");
			dtaGridViewTTHocVien.Columns.Add("MaUser", "Ma User");

			foreach (HocVien a in y)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dtaGridViewAdmin);
				row.Cells[0].Value = a.MaHocVien + "";
				row.Cells[1].Value = a.HoTen;
				row.Cells[2].Value = a.DiaChi + "";
				row.Cells[3].Value = a.MaUser + "";
				dtaGridViewTTHocVien.Rows.Add(row);
			}
		}

		void loadDataTTTeacher(List<GiaoVien> z)
		{
			dtaGridViewTTTeacher.Columns.Add("MaGiaoVien", "Ma Giao Vien");
			dtaGridViewTTTeacher.Columns.Add("HoTen", "Ho Ten");
			dtaGridViewTTTeacher.Columns.Add("DiaChi", "Dia Chi");
			dtaGridViewTTTeacher.Columns.Add("MaUser", "Ma User");

			foreach (GiaoVien a in z)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dtaGridViewAdmin);
				row.Cells[0].Value = a.MaGiaoVien + "";
				row.Cells[1].Value = a.HoTen;
				row.Cells[2].Value = a.DiaChi + "";
				row.Cells[3].Value = a.MaUser + "";
				dtaGridViewTTTeacher.Rows.Add(row);
			}
		}


		private void btnThem_Click(object sender, EventArgs e)
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

		private void FormAdmin_Load(object sender, EventArgs e)
		{
			//lay ds loai sach
			dsUser = db.C_User.ToList();
			dsHocVien = db.HocViens.ToList();
			dsGiaoVien = db.GiaoViens.ToList();

			//hien thi len datagird
			loadDataUser(dsUser);
			loadDataTTStudent(dsHocVien);
			loadDataTTTeacher(dsGiaoVien);
		}

		private void btnThemThongTin_Click(object sender, EventArgs e)
		{
			//kiem tra xem da co user muon them vao hay chua
			if (string.IsNullOrEmpty(txtMaHocVien.Text) || string.IsNullOrWhiteSpace(txtMaHocVien.Text)) return;
			if (string.IsNullOrEmpty(txtHoTenHV.Text) || string.IsNullOrWhiteSpace(txtHoTenHV.Text)) return;
			if (string.IsNullOrEmpty(txtDiaChiHV.Text) || string.IsNullOrWhiteSpace(txtDiaChiHV.Text)) return;

			//kiem tra xem co du lieu hay chua
			string ma = txtMaHocVien.Text;
			string hoTen = txtHoTenHV.Text;
			string diaChi = txtDiaChiHV.Text;
			string maUser = txtMaUserThamChieu.Text;

			List<HocVien> listHV = dsHocVien.Where(t => t.MaHocVien == ma).ToList();
			
			if (listHV.Count > 0)
			{
				MessageBox.Show("User nay da co vui long kiem tra lai");
				return;
			}		

			//xu ly them
			hocVien = new HocVien();
			hocVien.MaHocVien = ma;
			hocVien.HoTen = hoTen;
			hocVien.DiaChi = diaChi;
			hocVien.MaUser = maUser;

			//them vao dsls
			dsHocVien.Add(hocVien);

			//them vao dtagridview
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dtaGridViewTTHocVien);
			row.Cells[0].Value = ma;
			row.Cells[1].Value = hoTen;
			row.Cells[2].Value = diaChi;
			row.Cells[3].Value = maUser;
			dtaGridViewTTHocVien.Rows.Add(row);

			//them vao csdl
			db.HocViens.Add(hocVien);
			db.SaveChanges();

		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			//kiem tra xem da co user muon them vao hay chua
			if (string.IsNullOrEmpty(txtMaGiaoVien.Text) || string.IsNullOrWhiteSpace(txtMaGiaoVien.Text)) return;
			if (string.IsNullOrEmpty(txtHoTenGiaoVien.Text) || string.IsNullOrWhiteSpace(txtHoTenGiaoVien.Text)) return;
			if (string.IsNullOrEmpty(txtDiaChiGV.Text) || string.IsNullOrWhiteSpace(txtDiaChiGV.Text)) return;

			//kiem tra xem co du lieu hay chua
			string ma = txtMaGiaoVien.Text;
			string hoTen = txtHoTenGiaoVien.Text;
			string diaChi = txtDiaChiHV.Text;
			string maUser = txtMaUserGV.Text;

			List<GiaoVien> listGV = dsGiaoVien.Where(t => t.MaGiaoVien == ma).ToList();
			if (listGV.Count > 0)
			{
				MessageBox.Show("User nay da co vui long kiem tra lai");
				return;
			}

			//xu ly them
			giaoVien = new GiaoVien();
			giaoVien.MaGiaoVien = ma;
			giaoVien.HoTen = hoTen;
			giaoVien.DiaChi = diaChi;
			giaoVien.MaUser = maUser;

			//them vao dsls
			dsGiaoVien.Add(giaoVien);

			//them vao dtagridview

			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dtaGridViewTTTeacher);
			row.Cells[0].Value = ma;
			row.Cells[1].Value = hoTen;
			row.Cells[2].Value = diaChi;
			row.Cells[3].Value = maUser;
			dtaGridViewTTTeacher.Rows.Add(row);

			//them vao csdl
			db.GiaoViens.Add(giaoVien);
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

		private void dtaGridViewTTHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dtaGridViewTTHocVien.CurrentRow;
			int index = row.Index;
			if (index >= dsHocVien.Count)
				return;
			//hien thi thong tin tren cac txt
			hocVien = dsHocVien[index];
			txtMaHocVien.Text = hocVien.MaHocVien + "";
			txtHoTenHV.Text = hocVien.HoTen;
			txtDiaChiHV.Text = hocVien.DiaChi;
			txtMaUserThamChieu.Text = hocVien.MaUser;

		}

		private void dtaGridViewTTGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dtaGridViewTTTeacher.CurrentRow;
			int index = row.Index;
			if (index >= dsGiaoVien.Count)
				return;
			//hien thi thong tin tren cac txt
			giaoVien = dsGiaoVien[index];
			txtMaGiaoVien.Text = giaoVien.MaGiaoVien + "";
			txtHoTenGiaoVien.Text = giaoVien.HoTen;
			txtDiaChiGV.Text = giaoVien.DiaChi;
			txtMaUserGV.Text = giaoVien.MaUser;

		}

		private void btnXoaTTHocVien_Click(object sender, EventArgs e)
		{
			if (hocVien == null) return;

			//xoa trong csdl
			db.HocViens.Remove(hocVien);
			//xoa trong dsls
			dsHocVien.Remove(hocVien);
			//xoa trong luoi
			dtaGridViewTTHocVien.Rows.Remove(dtaGridViewTTHocVien.CurrentRow);
			//thiet lap lai gia tri ban dau cho hoc vien
			hocVien = null;
			MessageBox.Show("Xoa thanh cong");
			db.SaveChanges();
		}

		private void btnXoaTTGiaoVien_Click(object sender, EventArgs e)
		{
			if (giaoVien == null) return;

			//xoa trong csdl
			db.GiaoViens.Remove(giaoVien);
			//xoa trong dsls
			dsGiaoVien.Remove(giaoVien);
			//xoa trong luoi
			dtaGridViewTTTeacher.Rows.Remove(dtaGridViewTTTeacher.CurrentRow);
			//thiet lap lai gia tri ban dau cho hoc vien
			giaoVien = null;
			MessageBox.Show("Xoa thanh cong");
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
	}
}
