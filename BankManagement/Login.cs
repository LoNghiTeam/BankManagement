using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Login : Form
    {
        private Boolean check = false;
        public Login()
        {
            InitializeComponent();
        }

        private void icpbMK_MouseUp(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
        }

        private void icpbMK_MouseDown(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = false;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (check)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }
    }
}
