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
	public partial class FormThemTTHocVien : Form
	{
		CuoiKy_OOPEntities1 db = new CuoiKy_OOPEntities1();
		List<C_User> dsUser = new List<C_User>();
		List<HocVien> dsHocVien = new List<HocVien>();
		List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
		HocVien hocVien = null;

		public FormThemTTHocVien()
		{
			InitializeComponent();
		}

		private void FormThemTTHocVien_Load(object sender, EventArgs e)
		{
			//lay ds loai sach
			dsHocVien = db.HocViens.ToList();

			//hien thi len datagird
			loadDataTTStudent(dsHocVien);
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
				row.CreateCells(dtaGridViewTTHocVien);
				row.Cells[0].Value = a.MaHocVien + "";
				row.Cells[1].Value = a.HoTen;
				row.Cells[2].Value = a.DiaChi + "";
				row.Cells[3].Value = a.MaUser + "";
				dtaGridViewTTHocVien.Rows.Add(row);
			}
		}

		private void btnThemHV_Click(object sender, EventArgs e)
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

			MessageBox.Show("Them Thanh Cong");
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

		private void btnSuaThongTinHV_Click(object sender, EventArgs e)
		{
			if (hocVien == null) return;
			string hoTen = txtHoTenHV.Text;
			string diaChi = txtDiaChiHV.Text;
			string maUser = txtMaUserThamChieu.Text;

			/*List<C_User> x = dsUser.Where(a => a.MaUser == maUser).ToList();

			if (x.Count != null)
			{
				MessageBox.Show("Ma user da co vui long chon ten khac");
				return;
			}*/

			hocVien.HoTen = txtHoTenHV.Text;
			hocVien.DiaChi = txtDiaChiHV.Text;
			hocVien.MaUser = txtMaUserThamChieu.Text;

			db.SaveChanges();

			//cap nhat len luoi
			int index = dtaGridViewTTHocVien.CurrentRow.Index;
			dtaGridViewTTHocVien.Rows[index].Cells[1].Value = hoTen;
			dtaGridViewTTHocVien.Rows[index].Cells[2].Value = diaChi;
			dtaGridViewTTHocVien.Rows[index].Cells[3].Value = maUser;
			MessageBox.Show("Sua thanh cong");
		}
	}
}
