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
                tbxNewRate.Enabled = false;
                lblRate.Text = String.Empty;
            }
        }

        private void tbxNewRate__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
