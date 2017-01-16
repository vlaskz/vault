using System;
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
