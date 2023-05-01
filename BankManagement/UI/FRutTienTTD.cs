using BankManagement.Controller;
using BankManagement.DAO;
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
    public partial class FRutTienTTD : Form
    {
        private TheTinDung theTinDung;
        public TheTinDung TheTinDung { get => theTinDung; set => theTinDung = value; }
        private double soDu;
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        ChuyenTien chuyenTien = new ChuyenTien();
        TheTinDungDAO theTinDungDAO = new TheTinDungDAO();
        public FRutTienTTD(TheTinDung theTinDung, double soDu)
        {
            InitializeComponent();
            this.theTinDung = theTinDung;
            this.soDu = soDu;
        }

        private void FRutTienTTD_Load(object sender, EventArgs e)
        {
            lblMaSoThe.Text = theTinDung.MaTTD.ToString();
            lblRate.Text = soDu.ToString();
            lblSoTK.Text = theTinDung.SoTK.ToString();
            btnRut.Visible = false;

        }

        private void tbTienRut__TextChanged(object sender, EventArgs e)
        {
            double tienRut;
            if (double.TryParse(tbTienRut.Texts, out tienRut)){
                if (tienRut <= soDu)
                {
                    btnRut.Visible = true;
                }
                else
                {
                    btnRut.Visible = false;
                }
            }
            else
            {
                btnRut.Visible = false;
            }
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            double tienRut;
            double.TryParse(tbTienRut.Texts, out tienRut);
            taiKhoan = taiKhoanDAO.TimSoTK(theTinDung.SoTK);
            if (chuyenTien.GiaoDichTienGui(taiKhoan.SoTK, tienRut))
            {
                chuyenTien.TaoGiaoDich(taiKhoan.SoTK, 1, DateTime.Now, tienRut, 3);
                theTinDung.DaVay += tienRut;
                if (theTinDungDAO.CapNhatThe(theTinDung))
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Rút tiền không thành công", "Thông báo", MessageBoxButtons.OK);

            this.Dispose();
        }

        
    }
}
