﻿using System;
using System.Windows.Forms;
using System.Data;

namespace Vault
{
    public partial class frmConfCaixa : Form
    {
        public frmConfCaixa()
        {
            InitializeComponent();
        }


        public void carregaDados()
        {
            mySqlConnectionFactory db = new mySqlConnectionFactory();

          db.testConnection();

            
              cbxCheckout.DropDownStyle = ComboBoxStyle.DropDownList;
              cbxCheckout.DataSource = db.select("checkout", "SELECT numcheckout FROM CHECKOUT");
              cbxCheckout.ValueMember = "numcheckout";
              cbxCheckout.DisplayMember = "numcheckout";
              cbxCheckout.Update();

            cbxOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOperador.DataSource = db.select("operador", "SELECT cod,nome FROM operador");
            cbxOperador.ValueMember = "nome";
            cbxOperador.DisplayMember = "cod";
            cbxOperador.Update();

            cbxData.DropDownStyle = ComboBoxStyle.DropDown;
            cbxData.DataSource = db.select("confcaixa", "SELECT data from confcaixa");
            cbxData.ValueMember = "data";
            cbxData.DisplayMember = "data";
            cbxData.Update();
        }
        
        private void frmConfCaixa_Load(object sender, EventArgs e)
        {
            
            string message = "Duplo clique no nome do campo para desbloquear";
            new ToolTip().SetToolTip(lblCheckout,message);
            new ToolTip().SetToolTip(lblOperador, message);
            new ToolTip().SetToolTip(lblSaldoAtual,message);

           carregaDados();

        }

        private void tbSaldoAtual_Leave(object sender, EventArgs e)
        {
            tbSaldoAtual.ReadOnly=true;
            formatTextBox(tbSaldoAtual);
        }

        private void formatTextBox(TextBox tb)
        {
            if (tb.Text == "")
            {
                tb.Text = "0";
            }
            tb.MaxLength = 10;        
        }

        private void updateGbxCaixa()
        {
            if(cbxCheckout.SelectedItem!=null&&cbxOperador.SelectedItem!=null)
            gbxCaixa.Text = "Caixa:" + cbxCheckout.SelectedValue.ToString() + "." + cbxOperador.SelectedValue.ToString();
        }
        
        private void tbSaldoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
             validateTextBox(e);
        }

        private static void validateTextBox(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar !=',' && e.KeyChar != (char)Keys.Back)
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
            tbSaldoAtual.ReadOnly = false;

        }

        private void tbNP_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbNP);

        }

        private void tbNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbDebAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbDebAuto_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbDebAuto);
        }

        private void tbCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbCheque_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbCheque);
        }

        private void tbBoleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbBoleto_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbBoleto);
        }

        private void tbDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbDesconto_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbDesconto);
        }

        private void tbDespesa_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbBanco_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbPagMerc_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbPagMerc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbCompCred_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbCompCred_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbDevol_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbDevol_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbTroco_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbServelar_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbServelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbExtra_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbTotalCupom_Leave(object sender, EventArgs e)
        {
            formatTextBox((TextBox)(sender));
        }

        private void tbTotalCupom_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbTotalCupom_Enter(object sender, EventArgs e)
        {
            decimal result =
              
               
                Convert.ToDecimal(tbSaldoAtual.Text) +
                Convert.ToDecimal(tbDinheiro.Text) +
                Convert.ToDecimal(tbCartao.Text )+
                Convert.ToDecimal(tbNP.Text) +
                Convert.ToDecimal(tbDebAuto.Text) +
                Convert.ToDecimal(tbCheque.Text) +
                Convert.ToDecimal(tbBoleto.Text) +
                Convert.ToDecimal(tbDesconto.Text) +
                Convert.ToDecimal(tbDespesa.Text) +
                Convert.ToDecimal(tbBanco.Text) +
                Convert.ToDecimal(tbPagMerc.Text) +
                Convert.ToDecimal(tbCompCred.Text) +
                Convert.ToDecimal(tbDevol.Text) +
                Convert.ToDecimal(tbTroco.Text) +
                Convert.ToDecimal(tbServelar.Text) -
                Convert.ToDecimal(tbCredCli.Text) -
                Convert.ToDecimal(tbSaldoAnt.Text) -
                Convert.ToDecimal(tbExtra.Text);


            tbTotalCupom.Text = result.ToString();


        }

        private void tbCredCli_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbCredCli);
        }

        private void tbCredCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

        private void tbSaldoAnt_Leave(object sender, EventArgs e)
        {
            formatTextBox(tbSaldoAnt);
        }

        private void tbSaldoAnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextBox(e);
        }

       
    }
}


