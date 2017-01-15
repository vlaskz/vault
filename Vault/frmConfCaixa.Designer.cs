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
            this.tbSaldoAtual = new System.Windows.Forms.TextBox();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.cbxOperador = new System.Windows.Forms.ComboBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbDinheiro = new System.Windows.Forms.TextBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.cbxCheckout = new System.Windows.Forms.ComboBox();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.tbCartao = new System.Windows.Forms.TextBox();
            this.lblCartao = new System.Windows.Forms.Label();
            this.gbxCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCaixa
            // 
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
            this.gbxCaixa.Location = new System.Drawing.Point(12, 12);
            this.gbxCaixa.Name = "gbxCaixa";
            this.gbxCaixa.Size = new System.Drawing.Size(265, 392);
            this.gbxCaixa.TabIndex = 0;
            this.gbxCaixa.TabStop = false;
            this.gbxCaixa.Text = "Caixa";
            this.gbxCaixa.Enter += new System.EventHandler(this.gbxCaixa_Enter);
            // 
            // tbSaldoAtual
            // 
            this.tbSaldoAtual.Enabled = false;
            this.tbSaldoAtual.Location = new System.Drawing.Point(73, 79);
            this.tbSaldoAtual.MaxLength = 10;
            this.tbSaldoAtual.Name = "tbSaldoAtual";
            this.tbSaldoAtual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSaldoAtual.Size = new System.Drawing.Size(186, 20);
            this.tbSaldoAtual.TabIndex = 6;
            this.tbSaldoAtual.TextChanged += new System.EventHandler(this.tbSaldoAtual_TextChanged);
            this.tbSaldoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalAt0_KeyPress);
            this.tbSaldoAtual.Leave += new System.EventHandler(this.tbSalAt0_Leave);
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Location = new System.Drawing.Point(6, 82);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(61, 13);
            this.lblSaldoAtual.TabIndex = 5;
            this.lblSaldoAtual.Text = "Saldo Atual";
            this.lblSaldoAtual.DoubleClick += new System.EventHandler(this.lblSaldoAtual_DoubleClick);
            // 
            // cbxOperador
            // 
            this.cbxOperador.FormattingEnabled = true;
            this.cbxOperador.Location = new System.Drawing.Point(73, 51);
            this.cbxOperador.Name = "cbxOperador";
            this.cbxOperador.Size = new System.Drawing.Size(186, 21);
            this.cbxOperador.TabIndex = 3;
            this.cbxOperador.SelectedIndexChanged += new System.EventHandler(this.cbxOperador_SelectedIndexChanged);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(6, 54);
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
            // tbDinheiro
            // 
            this.tbDinheiro.Location = new System.Drawing.Point(73, 107);
            this.tbDinheiro.MaxLength = 10;
            this.tbDinheiro.Name = "tbDinheiro";
            this.tbDinheiro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDinheiro.Size = new System.Drawing.Size(186, 20);
            this.tbDinheiro.TabIndex = 8;
            this.tbDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDinheiro_KeyPress);
            this.tbDinheiro.Leave += new System.EventHandler(this.tbDinheiro_Leave);
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(6, 110);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(46, 13);
            this.lblDinheiro.TabIndex = 7;
            this.lblDinheiro.Text = "Dinheiro";
            // 
            // cbxCheckout
            // 
            this.cbxCheckout.FormattingEnabled = true;
            this.cbxCheckout.Location = new System.Drawing.Point(73, 23);
            this.cbxCheckout.Name = "cbxCheckout";
            this.cbxCheckout.Size = new System.Drawing.Size(186, 21);
            this.cbxCheckout.TabIndex = 10;
            this.cbxCheckout.SelectedIndexChanged += new System.EventHandler(this.cbxCheckout_SelectedIndexChanged);
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(6, 26);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(53, 13);
            this.lblCheckout.TabIndex = 9;
            this.lblCheckout.Text = "Checkout";
            this.lblCheckout.DoubleClick += new System.EventHandler(this.lblCheckout_DoubleClick);
            // 
            // tbCartao
            // 
            this.tbCartao.Location = new System.Drawing.Point(73, 135);
            this.tbCartao.MaxLength = 10;
            this.tbCartao.Name = "tbCartao";
            this.tbCartao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCartao.Size = new System.Drawing.Size(186, 20);
            this.tbCartao.TabIndex = 12;
            this.tbCartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCartao_KeyPress);
            this.tbCartao.Leave += new System.EventHandler(this.tbCartao_Leave);
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Location = new System.Drawing.Point(6, 138);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(38, 13);
            this.lblCartao.TabIndex = 11;
            this.lblCartao.Text = "Cartão";
            // 
            // frmConfCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 416);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbxCaixa);
            this.Name = "frmConfCaixa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conferência de Caixa";
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
    }
}