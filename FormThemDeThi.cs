using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_CuoiKy
{
    public partial class FormThemDeThi : Form
    {
        CuoiKy_OOPEntities7 db = new CuoiKy_OOPEntities7();
        List<CauHoi> dsCauHoi = new List<CauHoi>();
        List<MonHoc> dsMonHoc = new List<MonHoc>();
        List<DeThi> dsDeThi = new List<DeThi>();
        DeThi deThi = null;
        CauHoi cauHoi = null;
        MonHoc monHoc = null;
        string imglocation = "";
        public FormThemDeThi()
        {
            InitializeComponent();
        }

        private void ThemDeThi_Load(object sender, EventArgs e)
        {
            dsCauHoi = db.CauHois.ToList();
            dsMonHoc = db.MonHocs.ToList();

            loaddethi(dsDeThi);
            loadCauHoi(dsCauHoi);
        }
        void loaddethi(List<DeThi> x)
        {
            dataGridViewDeThi.Columns.Add("MaDeThi", "Ma De Thi");
            dataGridViewDeThi.Columns.Add("MaMonHoc", "Ma Mon Hoc");
            dataGridViewDeThi.Columns.Add("MaCauHoi", "Ma Cau Hoi");
            foreach (DeThi DT in x)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewDeThi);
                row.Cells[0].Value = DT.MaDeThi + "";
                row.Cells[1].Value = DT.MaMonHoc + "";


                dataGridViewDeThi.Rows.Add(row);
            }
        }
        void loadCauHoi(List<CauHoi> y)
        {
            
            dataGridViewCH.Columns.Add("MaCauHoi", "Ma Cau Hoi");
            dataGridViewCH.Columns.Add("MaChuong", "Ma Chuong");
            dataGridViewCH.Columns.Add("MaMonHoc", "Ma Mon Hoc");
            dataGridViewCH.Columns.Add("NoiDung", "Noi Dung");
            dataGridViewCH.Columns.Add("DapAn", "Dap An");
            foreach (CauHoi CH in y)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewCH);
                row.Cells[0].Value = CH.MaCauHoi + "";
                row.Cells[1].Value = CH.MaChuong + "";
                row.Cells[2].Value = CH.MaMonHoc + "";
                dataGridViewCH.Columns[3].Width = 100;
                row.Cells[3].Value = CH.HinhAnhCauHoi;
                row.Cells[4].Value = CH.DapAn;
                dataGridViewCH.Rows.Add(row);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDeThi.Text) || string.IsNullOrWhiteSpace(txtMaDeThi.Text)) return;
            if (string.IsNullOrEmpty(txtMaMonHoc.Text) || string.IsNullOrWhiteSpace(txtMaMonHoc.Text)) return;
            //if (string.IsNullOrEmpty(txtMaCauHoi.Text) || string.IsNullOrWhiteSpace(txtMaCauHoi.Text)) return;
            //try
            //{
            //    byte[] images = null;
            //    FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            //    BinaryReader brs = new BinaryReader(stream);
            //    images = brs.ReadBytes((int)stream.Length);

                string madethi = txtMaDeThi.Text;
                string mamonhoc = txtMaMonHoc.Text;
                //string macauhoi = txtMaCauHoi.Text;
                

                List<DeThi> dethi = dsDeThi.Where(t => t.MaDeThi == madethi).ToList();

                if (dethi.Count > 0)
                {
                    MessageBox.Show("ma de thi nay bi trung");
                    return;
                }




                deThi = new DeThi();
                deThi.MaDeThi = madethi;
                deThi.MaMonHoc = mamonhoc;
                //cauHoi.MaCauHoi = macauhoi;





                dsDeThi.Add(deThi);
                

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewDeThi);
                row.Cells[0].Value = madethi;
                row.Cells[1].Value = mamonhoc;
                //row.Cells[2].Value = macauhoi;
                dataGridViewDeThi.Rows.Add(row);

                db.DeThis.Add(deThi);
                db.SaveChanges();
                MessageBox.Show("Them De thi thanh cong");

            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.ToString());
            //}
        }

        private void dataGridViewDeThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDeThi.CurrentRow;
            int index = row.Index;
            if (index >= dsDeThi.Count)
                return;
            //hien thi thong tin tren cac txt
            deThi = dsDeThi[index];
            txtMaDeThi.Text = deThi.MaDeThi + "";
            txtMaMonHoc.Text = deThi.MaMonHoc;
           
        }

        private void dataGridViewCH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewCH.CurrentRow;
            int index = row.Index;
            if (index >= dsCauHoi.Count)
                return;
            cauHoi = dsCauHoi[index];
            txtMaCauHoi.Text = cauHoi.MaCauHoi;
        }

        Image file;
        //private void picBoxDeThi_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog f = new OpenFileDialog();
        //    f.Filter = "JPG (*.JPG)|*.jpg";
        //    if (f.ShowDialog() == DialogResult.OK)
        //    {
        //        imglocation = f.FileName.ToString();
        //        picBoxDeThi.ImageLocation = imglocation;
        //    }
        //    picBoxDeThi.SizeMode = PictureBoxSizeMode.StretchImage;
        //}

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (deThi == null) return;

            //xoa trong csdl
            db.DeThis.Remove(deThi);
            //xoa trong dsls
            dsDeThi.Remove(deThi);
            //xoa trong luoi
            dataGridViewDeThi.Rows.Remove(dataGridViewDeThi.CurrentRow);
            //thiet lap lai gia tri ban dau cho cau hoi
            deThi = null;
            MessageBox.Show("Xoa thanh cong");
            db.SaveChanges();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (deThi == null) return;

            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            string madethi = txtMaDeThi.Text;
            string mamonhoc = txtMaMonHoc.Text;





            deThi.MaDeThi = txtMaDeThi.Text;
            deThi.MaMonHoc = txtMaMonHoc.Text;


            db.SaveChanges();

            //cap nhat len luoi
            int index = dataGridViewDeThi.CurrentRow.Index;
            dataGridViewDeThi.Rows[index].Cells[1].Value = madethi;
            dataGridViewDeThi.Rows[index].Cells[2].Value = mamonhoc;

            MessageBox.Show("Sua thanh cong");
        }


    }
}
