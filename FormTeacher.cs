using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        CuoiKy_OOPEntities6 db = new CuoiKy_OOPEntities6();
        List<CauHoi> dsCauHoi = new List<CauHoi>();
        List<HocVien> dsHocVien = new List<HocVien>();
        List<Chuong> Chuongs = new List<Chuong>();
        C_User User = null;
        CauHoi cauHoi = null;
        Chuong chuong = null;
        string imgLocation = "";
        private void FormTeacher_Load(object sender, EventArgs e)
        {

        }
        void loadCauHoi(List<CauHoi> x)
        {
            dataGridViewKQ.Columns.Add("MaCauHoi", "Ma Cau Hoi");
            dataGridViewKQ.Columns.Add("MaChuong", "Ma Chuong");
            dataGridViewKQ.Columns.Add("MaMonHoc", "Ma Mon Hoc");
            dataGridViewKQ.Columns.Add("NoiDung", "Noi Dung");
            dataGridViewKQ.Columns.Add("DapAn", "Dap An");
            foreach (CauHoi CH in x )
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewKQ);
                row.Cells[0].Value = CH.MaCauHoi + "";
                row.Cells[1].Value = CH.MaChuong + "";
                row.Cells[2].Value = CH.MaMonHoc + "";
                dataGridViewKQ.Columns[3].Width = 150;
                row.Cells[3].Value = CH.HinhAnhCauHoi;
                row.Cells[4].Value = CH.DapAn;
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
            if (string.IsNullOrEmpty(txtMaChuong.Text) || string.IsNullOrWhiteSpace(txtMaChuong.Text)) return;
            if (string.IsNullOrEmpty(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtMaMon.Text)) return;

            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                string macauhoi = txtMaCauHoi.Text;
                string machuong = txtMaChuong.Text;
                string mamonhoc = txtMaMon.Text;
                string hinhanhcauhoi = picboxNDcauHoi.ImageLocation.ToString();
                int dapan = comboBox1.SelectedIndex;
                List<CauHoi> cauhoi = dsCauHoi.Where(t => t.MaCauHoi == macauhoi).ToList();

                if (cauhoi.Count > 0)
                {
                    MessageBox.Show("Cau hoi nay bi trung");
                    return;
                }




                cauHoi = new CauHoi();
                cauHoi.MaCauHoi = macauhoi;
                cauHoi.MaChuong = machuong;
                cauHoi.MaMonHoc = mamonhoc;
                cauHoi.HinhAnhCauHoi = images;
                cauHoi.DapAn = dapan;





                dsCauHoi.Add(cauHoi);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewKQ);
                row.Cells[0].Value = macauhoi;
                row.Cells[1].Value = machuong;
                row.Cells[2].Value = mamonhoc;
                row.Cells[3].Value = hinhanhcauhoi;
                row.Cells[4].Value = dapan;
                dataGridViewKQ.Rows.Add(row);

                db.CauHois.Add(cauHoi);
                db.SaveChanges();
                MessageBox.Show("Them cau hoi thanh cong");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }


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
            SqlConnection conn = new SqlConnection("Data Source=ASUSGHE;Initial Catalog=CuoiKy_OOP;Integrated Security=True");
            da = new SqlDataAdapter("Select * From HocVien where HoTen = " + txtTenHS.Text, conn);
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
            loadhs(dsHocVien);
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
            if (cauHoi.HinhAnhCauHoi != null)
            {
                MemoryStream ms = new MemoryStream(cauHoi.HinhAnhCauHoi);
                picboxNDcauHoi.Image = Image.FromStream(ms);
                picboxNDcauHoi.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picboxNDcauHoi.Image = null; // Xóa hình ảnh nếu không có dữ liệu
            }
            comboBox1.SelectedIndex = (int)cauHoi.DapAn;

        }


        Image file;
        private void picboxNDcauHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                imgLocation = f.FileName.ToString();
                picboxNDcauHoi.ImageLocation = imgLocation;
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

            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            string machuong = txtMaChuong.Text;
            string mamon = txtMaMon.Text;
            string hinhanhcauhoi = picboxNDcauHoi.ImageLocation.ToString();
            int dapan = comboBox1.SelectedIndex;




            cauHoi.MaChuong = txtMaChuong.Text;
            cauHoi.MaMonHoc = txtMaMon.Text;
            cauHoi.HinhAnhCauHoi = images;
            cauHoi.DapAn = dapan;

            db.SaveChanges();

            //cap nhat len luoi
            int index = dataGridViewKQ.CurrentRow.Index;
            dataGridViewKQ.Rows[index].Cells[1].Value = machuong;
            dataGridViewKQ.Rows[index].Cells[2].Value = mamon;
            dataGridViewKQ.Rows[index].Cells[3].Value = hinhanhcauhoi;
            dataGridViewKQ.Rows[index].Cells[4].Value = dapan;
            MessageBox.Show("Sua thanh cong");
        }

        private void dataGridViewHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


