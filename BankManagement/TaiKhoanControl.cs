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
    public partial class TaiKhoanControl : UserControl
    {
        private DataTable _dataSource;
        public event EventHandler ButtonClicked;
        public TaiKhoanControl()
        {
            InitializeComponent();
            this.dtgvBank.Size=new Size(Width,Height);
        }
        public DataTable DataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; dtgvBank.DataSource = _dataSource; }
        }
        protected void OnButtonClicked(EventArgs e)
        {
            if (ButtonClicked != null)
            {
                ButtonClicked(this, e);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            OnButtonClicked(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
