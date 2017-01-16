﻿using System;
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
                                                                                                    /*Ao tornar uma unica instância de dos campos, , trocando somente o numero
                                                                                                    do checkout, precisamos criar uma forma de controlar as alterações.
                                                                                                    Levando em consideração o fato de ás vezes os operadores de caixa
                                                                                                    trocarem de checkout.
                                                                                                    provavelmente inserir uma comboBox, e alterar o titulo da gbox
                                                                                                    conforme o checkout e o operador.*/

        public void carregaDados()
        {
            DatFileController dc = new DatFileController(); //inicializa a classe que manipula os  dados.
            for (int i = 0; i < dc.read(Config.operador).Count; i++)//carrega operadores de caixa para o combobox
                cbxOperador.Items.Add(dc.read(Config.operador)[i]);
            for (int i = 0; i < dc.read(Config.checkout).Count; i++)//carrega checkouts de caixa para o combobox
                cbxCheckout.Items.Add(dc.read(Config.checkout)[i]);

          
        }
        
        private void frmConfCaixa_Load(object sender, EventArgs e)
        {
            DatFileController dc = new DatFileController();
            carregaDados();

        }

        private void tbSalAt0_Leave(object sender, EventArgs e)
        {
            tbSaldoAtual.Enabled = false;
            formatTextBox(tbSaldoAtual);
        }

        private void formatTextBox(TextBox tb)
        {
            tb.MaxLength = 10;
         //   tb.Text = tb.Text.PadRight(8);
        }

        private void updateGbxCaixa()
        {
            if(cbxCheckout.SelectedItem!=null&&cbxOperador.SelectedItem!=null)
            gbxCaixa.Text = "Caixa:" + cbxCheckout.SelectedItem.ToString() + "." + cbxOperador.SelectedItem.ToString();
        }
        
        private void tbSalAt0_KeyPress(object sender, KeyPressEventArgs e)
        {
             validateTextBox(e);
        }

        private static void validateTextBox(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void gbxCaixa_Enter(object sender, EventArgs e)
        {

        }

        private void cbxOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxOperador.Enabled = false;
            updateGbxCaixa();
        }

        private void cbxCheckout_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCheckout.Enabled=false;
            updateGbxCaixa();
            
            
        }

        private void lblCheckout_DoubleClick(object sender, EventArgs e)
        {
            cbxCheckout.Enabled = true;
        }

        private void lblOperador_DoubleClick(object sender, EventArgs e)
        {
            cbxOperador.Enabled = true;
        }

        private void tbDinheiro_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbDinheiro);
        }

        private void tbDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbCartao_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbCartao);
        }

        private void tbCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void lblSaldoAtual_DoubleClick(object sender, EventArgs e)
        {
            tbSaldoAtual.Enabled = true;

        }

        private void tbSaldoAtual_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


