using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Vault
{
    public partial class frmConfCaixa : Form
    {
        public frmConfCaixa()
        {
            InitializeComponent();
        }


        public void carregaDados(ComboBox cbx, GroupBox gbx, int index)
        {
            DatFileController dc = new DatFileController(); //inicializa a classe que manipula os  dados.

            gbx0.Text = dc.read(Config.checkout)[index].ToString(); //carrega o nome do caixa pelo INDEX 

            for (int i = 0; i < dc.read(Config.operador).Count; i++)//carrega operadores de caixa para o combobox
                cbx.Items.Add(dc.read(Config.operador)[i]);

            cbx.SelectedIndex = index; //seleciona o valor padrão do INDEX
        }



        private void frmConfCaixa_Load(object sender, EventArgs e)
        {
            DatFileController dc = new DatFileController();

            //caixa 101 - default Nalva
            carregaDados(cbxOp0, gbx0, 0);

        }

        private void tbSalAt0_Leave(object sender, EventArgs e)
        {
            tbFormat(tbSalAt0);
        }

        private void tbFormat(TextBox tb)
        {
            tb.MaxLength = 10;
            tb.Text = tb.Text.PadRight(8);
        }

        private void tbSalAt0_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbValidate(e);
        }

        private static void tbValidate(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}


