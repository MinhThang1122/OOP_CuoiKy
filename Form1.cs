using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			SqlConnection loginCon = new SqlConnection("Data Source=ASUSGHE;Initial Catalog=CuoiKy_OOP;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from _User where TenDN = '"+txtTaiKhoan.Text+"' and MK = '"+txtMatKhau.Text+"'",loginCon);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			sda.Fill(dt);
			string cmbItemValue = comboBox1.SelectedItem.ToString();

			if (dt.Rows.Count > 0 )
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if (dt.Rows[i]["UserRoles"].ToString() == cmbItemValue)
					{
						MessageBox.Show("you are login as" + dt.Rows[i][2]);
						if(comboBox1.SelectedIndex==0)
						{
							FormAdmin admin = new FormAdmin();
							admin.Show();
							this.Hide();
						}
						else if (comboBox1.SelectedIndex==1)
						{
							FormStudent student = new FormStudent();
							student.Show();
							this.Hide();
							
						}
						else
						{
							FormTeacher formTeacher = new FormTeacher();
							formTeacher.Show();
							this.Hide();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Error");
			}

		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

	}


