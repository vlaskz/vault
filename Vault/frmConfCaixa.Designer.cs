namespace Vault
{
    partial class frmConfCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCaixa = new System.Windows.Forms.GroupBox();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.tbBoleto = new System.Windows.Forms.TextBox();
            this.lblBoleto = new System.Windows.Forms.Label();
            this.tbCheque = new System.Windows.Forms.TextBox();
            this.lblCheque = new System.Windows.Forms.Label();
            this.tbDebAuto = new System.Windows.Forms.TextBox();
            this.lblDebito = new System.Windows.Forms.Label();
            this.tbNP = new System.Windows.Forms.TextBox();
            this.lblNP = new System.Windows.Forms.Label();
            this.tbCartao = new System.Windows.Forms.TextBox();
            this.lblCartao = new System.Windows.Forms.Label();
            this.cbxCheckout = new System.Windows.Forms.ComboBox();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.tbDinheiro = new System.Windows.Forms.TextBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.tbSaldoAtual = new System.Windows.Forms.TextBox();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.cbxOperador = new System.Windows.Forms.ComboBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gbxCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCaixa
            // 
            this.gbxCaixa.Controls.Add(this.tbDesconto);
            this.gbxCaixa.Controls.Add(this.lblDesconto);
            this.gbxCaixa.Controls.Add(this.tbBoleto);
            this.gbxCaixa.Controls.Add(this.lblBoleto);
            this.gbxCaixa.Controls.Add(this.tbCheque);
            this.gbxCaixa.Controls.Add(this.lblCheque);
            this.gbxCaixa.Controls.Add(this.tbDebAuto);
            this.gbxCaixa.Controls.Add(this.lblDebito);
            this.gbxCaixa.Controls.Add(this.tbNP);
            this.gbxCaixa.Controls.Add(this.lblNP);
            this.gbxCaixa.Controls.Add(this.tbCartao);
            this.gbxCaixa.Controls.Add(this.lblCartao);
            this.gbxCaixa.Controls.Add(this.cbxCheckout);
            this.gbxCaixa.Controls.Add(this.lblCheckout);
            this.gbxCaixa.Controls.Add(this.tbDinheiro);
            this.gbxCaixa.Controls.Add(this.lblDinheiro);
            this.gbxCaixa.Controls.Add(this.tbSaldoAtual);
            this.gbxCaixa.Controls.Add(this.lblSaldoAtual);
            this.gbxCaixa.Controls.Add(this.cbxOperador);
            this.gbxCaixa.Controls.Add(this.lblOperador);
            this.gbxCaixa.Location = new System.Drawing.Point(5, 4);
            this.gbxCaixa.Name = "gbxCaixa";
            this.gbxCaixa.Size = new System.Drawing.Size(207, 481);
            this.gbxCaixa.TabIndex = 0;
            this.gbxCaixa.TabStop = false;
            this.gbxCaixa.Text = "Caixa";
            this.gbxCaixa.Enter += new System.EventHandler(this.gbxCaixa_Enter);
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(73, 207);
            this.tbDesconto.MaxLength = 10;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDesconto.Size = new System.Drawing.Size(130, 20);
            this.tbDesconto.TabIndex = 22;
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesconto_KeyPress);
            this.tbDesconto.Leave += new System.EventHandler(this.tbDesconto_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(7, 210);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(53, 13);
            this.lblDesconto.TabIndex = 21;
            this.lblDesconto.Text = "Desconto";
            // 
            // tbBoleto
            // 
            this.tbBoleto.Location = new System.Drawing.Point(73, 186);
            this.tbBoleto.MaxLength = 10;
            this.tbBoleto.Name = "tbBoleto";
            this.tbBoleto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbBoleto.Size = new System.Drawing.Size(130, 20);
            this.tbBoleto.TabIndex = 20;
            this.tbBoleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBoleto_KeyPress);
            this.tbBoleto.Leave += new System.EventHandler(this.tbBoleto_Leave);
            // 
            // lblBoleto
            // 
            this.lblBoleto.AutoSize = true;
            this.lblBoleto.Location = new System.Drawing.Point(7, 189);
            this.lblBoleto.Name = "lblBoleto";
            this.lblBoleto.Size = new System.Drawing.Size(37, 13);
            this.lblBoleto.TabIndex = 19;
            this.lblBoleto.Text = "Boleto";
            // 
            // tbCheque
            // 
            this.tbCheque.Location = new System.Drawing.Point(73, 165);
            this.tbCheque.MaxLength = 10;
            this.tbCheque.Name = "tbCheque";
            this.tbCheque.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCheque.Size = new System.Drawing.Size(130, 20);
            this.tbCheque.TabIndex = 18;
            this.tbCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheque_KeyPress);
            this.tbCheque.Leave += new System.EventHandler(this.tbCheque_Leave);
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.Location = new System.Drawing.Point(7, 168);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(44, 13);
            this.lblCheque.TabIndex = 17;
            this.lblCheque.Text = "Cheque";
            // 
            // tbDebAuto
            // 
            this.tbDebAuto.Location = new System.Drawing.Point(73, 144);
            this.tbDebAuto.MaxLength = 10;
            this.tbDebAuto.Name = "tbDebAuto";
            this.tbDebAuto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDebAuto.Size = new System.Drawing.Size(130, 20);
            this.tbDebAuto.TabIndex = 16;
            this.tbDebAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDebAuto_KeyPress);
            this.tbDebAuto.Leave += new System.EventHandler(this.tbDebAuto_Leave);
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Location = new System.Drawing.Point(7, 147);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(58, 13);
            this.lblDebito.TabIndex = 15;
            this.lblDebito.Text = "Déb. Auto.";
            // 
            // tbNP
            // 
            this.tbNP.Location = new System.Drawing.Point(73, 122);
            this.tbNP.MaxLength = 10;
            this.tbNP.Name = "tbNP";
            this.tbNP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNP.Size = new System.Drawing.Size(130, 20);
            this.tbNP.TabIndex = 14;
            this.tbNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNP_KeyPress);
            this.tbNP.Leave += new System.EventHandler(this.tbNP_Leave);
            // 
            // lblNP
            // 
            this.lblNP.AutoSize = true;
            this.lblNP.Location = new System.Drawing.Point(7, 125);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(22, 13);
            this.lblNP.TabIndex = 13;
            this.lblNP.Text = "NP";
            // 
            // tbCartao
            // 
            this.tbCartao.Location = new System.Drawing.Point(73, 100);
            this.tbCartao.MaxLength = 10;
            this.tbCartao.Name = "tbCartao";
            this.tbCartao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCartao.Size = new System.Drawing.Size(130, 20);
            this.tbCartao.TabIndex = 12;
            this.tbCartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCartao_KeyPress);
            this.tbCartao.Leave += new System.EventHandler(this.tbCartao_Leave);
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Location = new System.Drawing.Point(7, 103);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(38, 13);
            this.lblCartao.TabIndex = 11;
            this.lblCartao.Text = "Cartão";
            // 
            // cbxCheckout
            // 
            this.cbxCheckout.FormattingEnabled = true;
            this.cbxCheckout.Location = new System.Drawing.Point(73, 14);
            this.cbxCheckout.Name = "cbxCheckout";
            this.cbxCheckout.Size = new System.Drawing.Size(130, 21);
            this.cbxCheckout.TabIndex = 10;
            this.cbxCheckout.SelectedIndexChanged += new System.EventHandler(this.cbxCheckout_SelectedIndexChanged);
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(7, 17);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(53, 13);
            this.lblCheckout.TabIndex = 9;
            this.lblCheckout.Text = "Checkout";
            this.lblCheckout.DoubleClick += new System.EventHandler(this.lblCheckout_DoubleClick);
            // 
            // tbDinheiro
            // 
            this.tbDinheiro.Location = new System.Drawing.Point(73, 79);
            this.tbDinheiro.MaxLength = 10;
            this.tbDinheiro.Name = "tbDinheiro";
            this.tbDinheiro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDinheiro.Size = new System.Drawing.Size(130, 20);
            this.tbDinheiro.TabIndex = 8;
            this.tbDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDinheiro_KeyPress);
            this.tbDinheiro.Leave += new System.EventHandler(this.tbDinheiro_Leave);
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(7, 82);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(46, 13);
            this.lblDinheiro.TabIndex = 7;
            this.lblDinheiro.Text = "Dinheiro";
            // 
            // tbSaldoAtual
            // 
            this.tbSaldoAtual.Enabled = false;
            this.tbSaldoAtual.Location = new System.Drawing.Point(73, 58);
            this.tbSaldoAtual.MaxLength = 10;
            this.tbSaldoAtual.Name = "tbSaldoAtual";
            this.tbSaldoAtual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSaldoAtual.Size = new System.Drawing.Size(130, 20);
            this.tbSaldoAtual.TabIndex = 6;
            this.tbSaldoAtual.TextChanged += new System.EventHandler(this.tbSaldoAtual_TextChanged);
            this.tbSaldoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalAt0_KeyPress);
            this.tbSaldoAtual.Leave += new System.EventHandler(this.tbSalAt0_Leave);
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Location = new System.Drawing.Point(6, 61);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(61, 13);
            this.lblSaldoAtual.TabIndex = 5;
            this.lblSaldoAtual.Text = "Saldo Atual";
            this.lblSaldoAtual.DoubleClick += new System.EventHandler(this.lblSaldoAtual_DoubleClick);
            // 
            // cbxOperador
            // 
            this.cbxOperador.FormattingEnabled = true;
            this.cbxOperador.Location = new System.Drawing.Point(73, 36);
            this.cbxOperador.Name = "cbxOperador";
            this.cbxOperador.Size = new System.Drawing.Size(130, 21);
            this.cbxOperador.TabIndex = 3;
            this.cbxOperador.SelectedIndexChanged += new System.EventHandler(this.cbxOperador_SelectedIndexChanged);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(6, 39);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(51, 13);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.Text = "Operador";
            this.lblOperador.DoubleClick += new System.EventHandler(this.lblOperador_DoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(953, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 478);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Caixa";
            // 
            // frmConfCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 497);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbxCaixa);
            this.Name = "frmConfCaixa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vault - ConfCaixa";
            this.Load += new System.EventHandler(this.frmConfCaixa_Load);
            this.gbxCaixa.ResumeLayout(false);
            this.gbxCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCaixa;
        private System.Windows.Forms.ComboBox cbxOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.TextBox tbSaldoAtual;
        private System.Windows.Forms.TextBox tbDinheiro;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.ComboBox cbxCheckout;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.TextBox tbCartao;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox tbBoleto;
        private System.Windows.Forms.Label lblBoleto;
        private System.Windows.Forms.TextBox tbCheque;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.TextBox tbDebAuto;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.TextBox tbNP;
        private System.Windows.Forms.Label lblNP;
    }
}