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
    public partial class CSoTietKiem : UserControl
    {
        SoTietKiemDAO stkDAO = new SoTietKiemDAO();
        public CSoTietKiem()
        {
            InitializeComponent();
            this.dtgvGuiTK.Size = new Size(Width, Height);
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            this.dtgvGuiTK.DataSource = stkDAO.LayDanhSachSTK();
        }

        private void dtgvGuiTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvGuiTK.Rows[e.RowIndex];

                tbxMaSo.Texts = row.Cells[0].Value.ToString();
                tbxSTK.Texts = row.Cells[1].Value.ToString();
                tbxTenSo.Texts = row.Cells[2].Value.ToString();
                try
                {
                    dpNgayVay.Value = (DateTime)row.Cells[3].Value;
                    dpNgayHan.Value = (DateTime)row.Cells[4].Value;
                }
                catch
                {
                    dpNgayVay.Value = DateTime.Now;
                    dpNgayHan.Value = DateTime.Now;
                }
                tbxTien.Texts = row.Cells[5].Value.ToString();
                tbxMaLS.Texts = row.Cells[6].Value.ToString();
                tbxTinhTrang.Texts = row.Cells[7].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FTietKiem tietKiem = new FTietKiem();
            tietKiem.ShowDialog();
        }
    }
}
