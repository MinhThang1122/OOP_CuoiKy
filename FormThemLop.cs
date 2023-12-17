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
	public partial class FormThemLop : Form
	{
		CuoiKy_OOPEntities4 db = new CuoiKy_OOPEntities4();
		List<LopHoc> dsLop = new List<LopHoc>();
		LopHoc lop = null;

		public FormThemLop()
		{
			InitializeComponent();
		}

		private void FormThemLop_Load(object sender, EventArgs e)
		{
			//lay ds lop
			dsLop = db.LopHocs.ToList();

			//hien thi len datagird
			loadDataLop(dsLop);
		}

		void loadDataLop(List<LopHoc> x)
		{
			dtaGridViewLop.Columns.Add("MaLop", "Ma Lop");
			dtaGridViewLop.Columns.Add("TenLop", "Ten Lop");

			foreach (LopHoc a in x)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dtaGridViewLop);
				row.Cells[0].Value = a.MaLopHoc + "";
				row.Cells[1].Value = a.TenLopHoc;
				dtaGridViewLop.Rows.Add(row);
			}
		}

		private void btnThemLop_Click(object sender, EventArgs e)
		{
			//kiem tra xem da co lop muon them vao hay chua
			if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtMaLop.Text)) return;

			//kiem tra xem co du lieu hay chua
			string maLop = txtMaLop.Text;
			string tenLop = txtTenLop.Text;

			List<LopHoc> list = dsLop.Where(t => t.MaLopHoc == maLop).ToList();

			if (list.Count > 0)
			{
				MessageBox.Show("User nay da co vui long kiem tra lai");
				return;
			}

			//xu ly them
			lop = new LopHoc();
			lop.MaLopHoc = maLop;
			lop.TenLopHoc = tenLop;

			MessageBox.Show("Them thanh cong");

			//them vao dsls
			dsLop.Add(lop);

			//them vao dtagridview
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dtaGridViewLop);
			row.Cells[0].Value = maLop;
			row.Cells[1].Value = tenLop;
			dtaGridViewLop.Rows.Add(row);

			//them vao csdl
			db.LopHocs.Add(lop);
			db.SaveChanges();
		}

		private void btnXoaLop_Click(object sender, EventArgs e)
		{
			if (lop == null) return;

			//xoa trong csdl
			db.LopHocs.Remove(lop);
			//xoa trong dsls
			dsLop.Remove(lop);
			//xoa trong luoi
			dtaGridViewLop.Rows.Remove(dtaGridViewLop.CurrentRow);
			//thiet lap lai gia tri ban dau cho hoc vien
			lop = null;
			MessageBox.Show("Xoa thanh cong");
			db.SaveChanges();
		}

		private void btnSuaLop_Click(object sender, EventArgs e)
		{
			if (lop == null) return;
			string maLop = txtMaLop.Text;
			string tenLop = txtTenLop.Text;

			lop.TenLopHoc = txtTenLop.Text;

			db.SaveChanges();

			//cap nhat len luoi
			int index = dtaGridViewLop.CurrentRow.Index;
			dtaGridViewLop.Rows[index].Cells[1].Value = tenLop;
			MessageBox.Show("Sua thanh cong");
		}
		private void dtaGridViewLop_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dtaGridViewLop.CurrentRow;
			int index = row.Index;
			if (index >= dsLop.Count)
				return;
			//hien thi thong tin tren cac txt
			lop = dsLop[index];
			txtMaLop.Text = lop.MaLopHoc + "";
			txtTenLop.Text = lop.TenLopHoc;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}
	}
}
