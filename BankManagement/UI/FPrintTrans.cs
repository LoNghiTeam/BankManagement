using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagement.Model;

namespace BankManagement.UI
{
    public partial class FPrintTrans : Form
    {
        private GiaoDich _data;
        public FPrintTrans(GiaoDich data)
        {
            InitializeComponent();
            _data = data;
        }

        private void FPrintTrans_Load(object sender, EventArgs e)
        {
            
        }
    }
}
