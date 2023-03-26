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
        DieuChinhLaiSuat dieuChinh = new DieuChinhLaiSuat();
        public FLaiSuat()
        {
            InitializeComponent();
        }

        private void FLaiSuat_Load(object sender, EventArgs e)
        {
            laiSuat = vayTien.GetLaiSuat();
            btnChange.Enabled = false;
            lblRate.Text = string.Empty;
            tbxNewRate.Enabled = false;
            cbTypeRate.Items.Add("Lãi vay");
            cbTypeRate.Items.Add("Lãi gửi");
        }

        private void cbTypeRate_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            tbxNewRate.Enabled = true;
            if (cbTypeRate.Texts.Equals("Lãi vay"))
            {
                type = 1;
                lblRate.Text = (laiSuat.LaiVay * 100).ToString() + "%";
            }

            else if (cbTypeRate.Texts.Equals("Lãi gửi"))
            {
                type = 2;
                lblRate.Text = (laiSuat.LaiGui * 100).ToString() + "%";
            }

            else
            {
                type = 0;
                tbxNewRate.Enabled = false;
                lblRate.Text = String.Empty; 
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
                laiSuat = vayTien.GetLaiSuat();
                if(type == 2)
                {
                    lblRate.Text = (laiSuat.LaiGui * 100).ToString() + "%";
                }
                else
                {
                    lblRate.Text = (laiSuat.LaiVay * 100).ToString() + "%";
                }
            }

            else
                MessageBox.Show("Điều chỉnh thất bại", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
