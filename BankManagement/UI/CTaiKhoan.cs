using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class CTaiKhoan : UserControl
    {
        KhachHangDAO khDAO = new KhachHangDAO();
        //public event EventHandler ButtonClicked;
        public CTaiKhoan()
        {
            InitializeComponent();
            this.dtgvBank.Size=new Size(Width,Height);
            HienThiDanhSach();
        }
        //protected void OnButtonClicked(object sender, EventArgs e)
        //{
        //    if (ButtonClicked != null)
        //    {
        //        ButtonClicked(sender, e);
        //    }
        //}
        private void HienThiDanhSach()
        {
            this.dtgvBank.DataSource = khDAO.LayDanhSachKH();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(
                tbxSTK.Texts,
                tbxName.Texts,
                dpNgaySinh.Value,
                tbxCCCD.Texts,
                tbxQueQuan.Texts,
                tbxSDT.Texts, 1);

            if (IsValid(tk))
            {
                khDAO.Sua(tk);
            }

            HienThiDanhSach();
            //OnButtonClicked(sender,e);
        }
        bool IsValid(TaiKhoan tk)
        {
            if (string.IsNullOrWhiteSpace(tk.SoTK.ToString()) ||
                string.IsNullOrWhiteSpace(tk.HoTen) ||
                string.IsNullOrWhiteSpace(tk.NgaySinh.ToString()) ||
                string.IsNullOrWhiteSpace(tk.Cccd) ||
                string.IsNullOrWhiteSpace(tk.DiaChi) ||
                string.IsNullOrWhiteSpace(tk.SoDienThoai))
            {
                MessageBox.Show("Không được để trống!");
                return false;
            }

            if (IsValidPhone(tk.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return false;
            }

            return true;
        }
        public bool IsValidPhone(string sdt)
        {
            string pattern = @"^\d{3}-?\d{3}-?\d{4}$";
            return Regex.IsMatch(sdt, pattern);
        }

        private void dtgvBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvBank.Rows[e.RowIndex];

                tbxName.Texts = row.Cells[1].Value.ToString();
                tbxSTK.Texts = row.Cells[0].Value.ToString();
                tbxQueQuan.Texts = row.Cells[4].Value.ToString();
                try
                {
                    dpNgaySinh.Value = (DateTime)row.Cells[2].Value;
                }
                catch
                {
                    dpNgaySinh.Value = DateTime.Now;
                }
                tbxCCCD.Texts = row.Cells[3].Value.ToString();
                tbxSDT.Texts = row.Cells[5].Value.ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(
                tbxSTK.Texts,
                tbxName.Texts,
                dpNgaySinh.Value,
                tbxCCCD.Texts,
                tbxQueQuan.Texts,
                tbxSDT.Texts, 1);

            if (IsValid(tk))
            {
                khDAO.Them(tk);
            }

            HienThiDanhSach();
        }
    }
}
