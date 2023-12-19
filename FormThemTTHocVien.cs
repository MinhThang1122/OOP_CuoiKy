using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAn_CuoiKy
{
	public partial class FormThemTTHocVien : Form
	{
		CuoiKy_OOPEntities7 db = new CuoiKy_OOPEntities7();
		List<C_User> dsUser = new List<C_User>();
		List<HocVien> dsHocVien = new List<HocVien>();
		List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
		HocVien hocVien = null;
		string imagLocation = "";

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
            dtaGridViewTTHocVien.Columns.Add("HinhAnh", "Hinh Anh");

            foreach (HocVien a in y)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dtaGridViewTTHocVien);
				row.Cells[0].Value = a.MaHocVien + "";
				row.Cells[1].Value = a.HoTen;
				row.Cells[2].Value = a.DiaChi + "";
				row.Cells[3].Value = a.MaUser + "";
                row.Cells[4].Value = a.HinhAnh + "";
                dtaGridViewTTHocVien.Rows.Add(row);
			}
		}

		private void btnThemHV_Click(object sender, EventArgs e)
		{
			//kiem tra xem da co user muon them vao hay chua
			if (string.IsNullOrEmpty(txtMaHocVien.Text) || string.IsNullOrWhiteSpace(txtMaHocVien.Text)) return;
			if (string.IsNullOrEmpty(txtHoTenHV.Text) || string.IsNullOrWhiteSpace(txtHoTenHV.Text)) return;
			if (string.IsNullOrEmpty(txtDiaChiHV.Text) || string.IsNullOrWhiteSpace(txtDiaChiHV.Text)) return;
            try
            {
				byte[] images = null;
				FileStream stream = new FileStream(imagLocation, FileMode.Open, FileAccess.Read);
				BinaryReader brs = new BinaryReader(stream);	
				images = brs.ReadBytes((int)stream.Length);

                //kiem tra xem co du lieu hay chua

                string ma = txtMaHocVien.Text;
                string hoTen = txtHoTenHV.Text;
                string diaChi = txtDiaChiHV.Text;
                string maUser = txtMaUserThamChieu.Text;
                string hinhAnh = picBoxHocVien.ImageLocation.ToString();

                
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
                hocVien.HinhAnh = images;



                //them vao dsls
                dsHocVien.Add(hocVien);

                //them vao dtagridview
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtaGridViewTTHocVien);
                row.Cells[0].Value = ma;
                row.Cells[1].Value = hoTen;
                row.Cells[2].Value = diaChi;
                row.Cells[3].Value = maUser;
                row.Cells[4].Value = hinhAnh;
                dtaGridViewTTHocVien.Rows.Add(row);

                //them vao csdl
                db.HocViens.Add(hocVien);
                db.SaveChanges();

                MessageBox.Show("Them Thanh Cong");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
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
            // Hiển thị hình ảnh từ dữ liệu byte[]
            if (hocVien.HinhAnh != null)
            {
                MemoryStream ms = new MemoryStream(hocVien.HinhAnh);
                picBoxHocVien.Image = Image.FromStream(ms);
                picBoxHocVien.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picBoxHocVien.Image = null; // Xóa hình ảnh nếu không có dữ liệu
            }


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

            byte[] images = null;
            FileStream stream = new FileStream(imagLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            string hoTen = txtHoTenHV.Text;
            string diaChi = txtDiaChiHV.Text;
            string maUser = txtMaUserThamChieu.Text;
            string hinhAnh = picBoxHocVien.ImageLocation.ToString();

            /*List<C_User> x = dsUser.Where(a => a.MaUser == maUser).ToList();

			if (x.Count != null)
			{
				MessageBox.Show("Ma user da co vui long chon ten khac");
				return;
			}*/



            hocVien.HoTen = txtHoTenHV.Text;
            hocVien.DiaChi = txtDiaChiHV.Text;
            hocVien.MaUser = txtMaUserThamChieu.Text;
            hocVien.HinhAnh = images;

            db.SaveChanges();

            //cap nhat len luoi
            int index = dtaGridViewTTHocVien.CurrentRow.Index;
            dtaGridViewTTHocVien.Rows[index].Cells[1].Value = hoTen;
            dtaGridViewTTHocVien.Rows[index].Cells[2].Value = diaChi;
            dtaGridViewTTHocVien.Rows[index].Cells[3].Value = maUser;
            dtaGridViewTTHocVien.Rows[index].Cells[4].Value = hinhAnh;
            MessageBox.Show("Sua thanh cong");
        }

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Close();
		}


        Image file;
        private void picBoxHocVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
               
				imagLocation = f.FileName.ToString();
				picBoxHocVien.ImageLocation = imagLocation;
            }
            picBoxHocVien.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
