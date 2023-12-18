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
	public partial class FormThemTTGiaoVien : Form
	{
		CuoiKy_OOPEntities6 db = new CuoiKy_OOPEntities6();
		List<C_User> dsUser = new List<C_User>();
		List<HocVien> dsHocVien = new List<HocVien>();
		List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
		GiaoVien giaoVien = null;

		public FormThemTTGiaoVien()
		{
			InitializeComponent();
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
				row.CreateCells(dtaGridViewTTTeacher);
				row.Cells[0].Value = a.MaGiaoVien + "";
				row.Cells[1].Value = a.HoTen;
				row.Cells[2].Value = a.DiaChi + "";
				row.Cells[3].Value = a.MaUser + "";
				dtaGridViewTTTeacher.Rows.Add(row);
			}
		}

		private void FormThemTTGiaoVien_Load(object sender, EventArgs e)
		{
			//lay ds loai sach
			dsGiaoVien = db.GiaoViens.ToList();

			//hien thi len datagird
			loadDataTTTeacher(dsGiaoVien);
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

		private void btnThemGV_Click(object sender, EventArgs e)
		{
			//kiem tra xem da co user muon them vao hay chua
			if (string.IsNullOrEmpty(txtMaGiaoVien.Text) || string.IsNullOrWhiteSpace(txtMaGiaoVien.Text)) return;
			if (string.IsNullOrEmpty(txtHoTenGiaoVien.Text) || string.IsNullOrWhiteSpace(txtHoTenGiaoVien.Text)) return;
			if (string.IsNullOrEmpty(txtDiaChiGV.Text) || string.IsNullOrWhiteSpace(txtDiaChiGV.Text)) return;

			//kiem tra xem co du lieu hay chua
			string ma = txtMaGiaoVien.Text;
			string hoTen = txtHoTenGiaoVien.Text;
			string diaChi = txtDiaChiGV.Text;
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

			MessageBox.Show("Them Thanh Cong");
		}

		private void btnSuaTTGV_Click(object sender, EventArgs e)
		{
			if (giaoVien == null) return;

			string tenGV = txtHoTenGiaoVien.Text;
			string diaChi = txtDiaChiGV.Text;
			string maUser = txtMaUserGV.Text;

			/*List<C_User> x = dsUser.Where(a => a.MaUser == maUser).ToList();

			if (x.Count != null)
			{
				MessageBox.Show("Ma user da co vui long chon ten khac");
				return;
			}*/

			giaoVien.HoTen = txtHoTenGiaoVien.Text;
			giaoVien.DiaChi = txtDiaChiGV.Text;
			giaoVien.MaUser = txtMaUserGV.Text;

			db.SaveChanges();

			//cap nhat len luoi
			int index = dtaGridViewTTTeacher.CurrentRow.Index;
			dtaGridViewTTTeacher.Rows[index].Cells[1].Value = tenGV;
			dtaGridViewTTTeacher.Rows[index].Cells[2].Value = diaChi;
			dtaGridViewTTTeacher.Rows[index].Cells[3].Value = maUser;
			MessageBox.Show("Sua thanh cong");
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Close();
		}
	}
}
