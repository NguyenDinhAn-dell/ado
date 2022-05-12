using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ado1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Ok = false;
            SqlConnection conn = new SqlConnection(@"Data Source=LAB2-MAY18\SQLEXPRESS;Initial Catalog=QLHV;Integrated Security=True; ");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Nguoidung", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if ((txt1.Text.Trim() == rdr["Tendangnhap"].
                    ToString().Trim()) && txt2.Text.Trim() ==
                    rdr["Matkhau"].ToString().Trim())
            Ok = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                return;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            if (Ok == false)
            {
                MessageBox.Show("Tên đăng nhập/Mật khẩu không hợp lệ!");
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                admin f = new admin();
                f.Show();
                this.Hide();
                
            }

        }
    }

    }
