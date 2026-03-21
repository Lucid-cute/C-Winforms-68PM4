using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlSinhvien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            DatabaseDataContext db = new DatabaseDataContext();
            var account = db.Accounts.FirstOrDefault(
                acc => acc.email == email && acc.password == pass);
            if (account != null) {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                ClassForm classForm = new ClassForm();
                classForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
