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
        private Dictionary<int, int> selectedAnswers = new Dictionary<int, int>();

        private int currentQuestionIndex;


        public FormThi()
        {
            InitializeComponent();
            currentQuestionIndex = 0;
        }

        private void FormThi_Load(object sender, EventArgs e)
        {


            dsCauHoi = db.CauHois.ToList();
            dsMonHoc = db.MonHocs.ToList();
            dsDeThi = db.DeThis.ToList();
            txtDeThi.Text = dsDeThi[0].MaDeThi;
            DisplayQuestion();



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
            // Lưu trạng thái ComboBox vào biến selectedAnswers
            if (!selectedAnswers.ContainsKey(currentQuestionIndex))
            {
                selectedAnswers.Add(currentQuestionIndex, comboBox1.SelectedIndex);
            }
            if (currentQuestionIndex < dsCauHoi.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion();
            }
            button3.Visible = true;

            if (currentQuestionIndex == 9)
            {
                button2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!selectedAnswers.ContainsKey(currentQuestionIndex))
            {
                selectedAnswers.Add(currentQuestionIndex, comboBox1.SelectedIndex);
            }
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion();
            }

            if (currentQuestionIndex == 0)
            {
                button3.Visible = false;
                button2.Visible = true;
            }

        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < dsDeThi.Count)
            {
                DeThi deThi = dsDeThi[currentQuestionIndex];
                CauHoi cauHoi = dsCauHoi.FirstOrDefault(c => c.MaCauHoi == deThi.MaCauHoi);
                if (cauHoi != null)
                {
                    // Đặt lại giá trị chọn trong ComboBox
                    comboBox1.SelectedIndex = selectedAnswers.ContainsKey(currentQuestionIndex)
                        ? selectedAnswers[currentQuestionIndex]
                        : -1;

                    MemoryStream ms = new MemoryStream(cauHoi.HinhAnhCauHoi);
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtMonHoc.Text = cauHoi.MonHoc.TenMonHoc;
                }
            }
        }
    }
}
