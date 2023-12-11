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
	}
}
