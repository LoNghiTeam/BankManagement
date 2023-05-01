using BankManagement.Controller;
using BankManagement.Model;
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
    public partial class FLaiSuat : Form
    {
        int type;
        LaiSuat laiSuat = new LaiSuat();
        VayTien vayTien = new VayTien();
        HoatDongLaiSuat hdLS = new HoatDongLaiSuat();
        DieuChinhLaiSuat dieuChinh = new DieuChinhLaiSuat();
        public FLaiSuat()
        {
            InitializeComponent();
        }

        private void FLaiSuat_Load(object sender, EventArgs e)
        {
            laiSuat = hdLS.GetLaiSuat(laiSuat);
            btnChange.Enabled = false;
            lblRate.Text = string.Empty;
            tbxNewRate.Enabled = false;
            cbTypeRate.Items.Add("Lãi vay");
            cbTypeRate.Items.Add("Lãi gửi");
            cbTypeRate.Items.Add("Tỉ lệ");
            cbTypeRate.Items.Add("Giá trị quy đổi điểm tín dụng");
        }

        private void cbTypeRate_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            tbxNewRate.Enabled = true;
            switch (cbTypeRate.Texts)
            {
                case ("Lãi vay"):
                    type = 1;
                    lblRate.Text = (laiSuat.LaiVay * 100).ToString() + "%";
                    break;
                case ("Lãi gửi"):
                    type = 2;
                    lblRate.Text = (laiSuat.LaiGui * 100).ToString() + "%";
                    break;
                case ("Tỉ lệ"):
                    type = 3;
                    lblRate.Text = laiSuat.TiLe.ToString();
                    break;
                case ("Giá trị quy đổi điểm tín dụng"):
                    type = 4;
                    lblRate.Text = laiSuat.QuyDoiTD.ToString();
                    break;
                default:
                    type = 0;
                    tbxNewRate.Enabled = false;
                    lblRate.Text = String.Empty;
                    break;

            }
        }

        private void tbxNewRate__TextChanged(object sender, EventArgs e)
        {
             double rate;
            
            if(double.TryParse(tbxNewRate.Texts, out rate))
            {
                btnChange.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(dieuChinh.dieuchinh(type, laiSuat, double.Parse(tbxNewRate.Texts)))
            {
                MessageBox.Show("Điều chỉnh thành công", "Thông báo", MessageBoxButtons.OK);
                laiSuat = hdLS.GetLaiSuat(laiSuat);
                switch (type)
                {
                    case (1):
                        lblRate.Text = (laiSuat.LaiVay * 100).ToString() + "%";
                        break;
                    case (2):
                        lblRate.Text = (laiSuat.LaiGui * 100).ToString() + "%";
                        break;
                    case (3):
                        lblRate.Text = laiSuat.TiLe.ToString();
                        break;
                    case (4):
                        lblRate.Text = laiSuat.QuyDoiTD.ToString();
                        break;
                    default:
                        tbxNewRate.Enabled = false;
                        lblRate.Text = String.Empty;
                        break;
                }
            }

            else
                MessageBox.Show("Điều chỉnh thất bại", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
