using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vault
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnConfCaixa_Click(object sender, EventArgs e)
        {
            Hide();
            new frmConfCaixa().ShowDialog();

            
            
        }
    }
}
