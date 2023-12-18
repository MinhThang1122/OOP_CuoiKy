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
    public partial class FormThi : Form
    {
        CuoiKy_OOPEntities6 db = new CuoiKy_OOPEntities6();
        List<CauHoi> dsCauHoi = new List<CauHoi>();
        List<DeThi> dsDeThi = new List<DeThi>();

        public FormThi()
        {
            InitializeComponent();
        }

        private void FormThi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
