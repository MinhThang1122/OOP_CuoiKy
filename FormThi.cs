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

namespace DoAn_CuoiKy
{
    public partial class FormThi : Form
    {
        CuoiKy_OOPEntities9 db = new CuoiKy_OOPEntities9();
        List<CauHoi> dsCauHoi = new List<CauHoi>();
        List<DeThi> dsDeThi = new List<DeThi>();
        List<MonHoc> dsMonHoc = new List<MonHoc>();
        List<BaiLam> dsBaiLam = new List<BaiLam>();
        BaiLam baiLam = null;
        CauHoi cauHoi = null;
        MonHoc monHoc = null;
        

        public FormThi()
        {
            InitializeComponent();
        }

        private void FormThi_Load(object sender, EventArgs e)
        {
                dsCauHoi = db.CauHois.ToList();
                dsMonHoc = db.MonHocs.ToList();
            
                MemoryStream ms = new MemoryStream(dsCauHoi[0].HinhAnhCauHoi);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                txtMonHoc.Text = dsMonHoc[0].TenMonHoc;
            
                
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dsCauHoi = db.CauHois.ToList();
        }
    }
}
