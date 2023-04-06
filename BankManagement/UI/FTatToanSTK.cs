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

namespace BankManagement.UI
{
    public partial class FTatToanSTK : Form
    {
        private SoTietKiem stk;
        public SoTietKiem STK { get => stk; set => stk = value; }
        public FTatToanSTK()
        {
            InitializeComponent();
        }
        public FTatToanSTK(SoTietKiem stk)
        {
            InitializeComponent();
            this.stk = stk;
        }

        private void FTatToanSTK_Load(object sender, EventArgs e)
        {
            lblMaSo.Text = stk.MaSTK.ToString();
            lblSTK.Text = stk.SoTK.ToString();
            lblTenSo.Text = stk.TenSo;
            lblNgayGD.Text = stk.NgayVay.ToString();
            lblSoTien.Text = stk.Tien.ToString();
            lblMaLS.Text = stk.MaLS.ToString();
            lblTT.Text = "Chua xu ly";

            lblDaoHan.Text = stk.NgayHan.ToString();
            lblTatToan.Text = DateTime.Now.ToString();
            TimeSpan duration = stk.NgayHan - DateTime.Now;  
            int days = Math.Abs(duration.Days);
            lblSai.Text = days.ToString();
            
        }
    }
}
