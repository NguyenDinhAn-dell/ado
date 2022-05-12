using System;
using System.Windows.Forms;
namespace ado1
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }


        #region
        public void loadData()
        {
            string sql = "select * from Nguoidung";
            data.DataSource = KetNoi.getData(sql);
        }

        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            if (i >= 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string t = data.Rows[i].Cells[0].Value.ToString();
                    string sql = string.Format("delete from Nguoidung where Tendangnhap ='{0}'", t);
                    object[] value = { };
                    string[] name = { };

                    KetNoi.moKetNoi();
                    KetNoi.updateData(sql, value, name, 0);
                    load();
                    KetNoi.dongKetNoi();
                }
            }
        }
        #region
        public void load()
        {
            string sql = "select * from Nguoidung";
            data.DataSource = KetNoi.getData(sql);
        }
        #endregion

        private void btnadd_Click(object sender, EventArgs e)
        {
            string sql = "Insert Into Nguoidung values(@tenDangNhap, @matKhau)";
            string[] name = { "@tenDangNhap", "@matKhau" };
            object[] value = { txt1.Text, txt2.Text };
            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 2);
            load();
            KetNoi.dongKetNoi();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();

            load();
            KetNoi.dongKetNoi();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           

        }

        private void btnreload_Click(object sender, EventArgs e)
        {

        }
    }
}
