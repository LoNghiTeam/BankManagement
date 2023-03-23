using BankManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.UI
{
    public partial class FChangePass : Form
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public FChangePass()
        {
            InitializeComponent();
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            if(logging.Taikhoan.Pass == tbxOldPass.Texts)
            {
                panel3.Enabled= true;
                tbxNewPass.Focus();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng, vui lòng nhập lại!");
                tbxOldPass.Focus();
            }
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbxNewPass.Texts) || String.IsNullOrEmpty(tbxNewPass.Texts)){
                MessageBox.Show("Không được để trống!");
            }else if(tbxNewPass.Texts.Length <6)
            {
                MessageBox.Show("Mật khẩu phải có hơn 5 ký tự!");
            }else if(tbxNewPass.Texts == tbxOldPass.Texts)
            {
                MessageBox.Show("Không được nhập lại mật khẩu cũ!");
                tbxNewPass.Focus();
            }else if (tbxRNewPass.Texts != tbxNewPass.Texts)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                tbxRNewPass.Focus();
            }else
            {
                if (tkDAO.DoiMatKhau(tbxNewPass.Texts)) 
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại, vui lòng thử lại sau!");
                }
            }
        }
    }
}
