using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
	public partial class FormThongTinStudent : Form
	{

        public FormThongTinStudent()
		{
			InitializeComponent();
		}


        private void btnThi_Click(object sender, EventArgs e)
		{
			FormThi f = new FormThi();
			f.ShowDialog();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Hide();
		}

        private void FormThongTinStudent_Load(object sender, EventArgs e)
        {
    

        }


    }
}
