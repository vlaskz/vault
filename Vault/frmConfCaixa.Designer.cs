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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOperador = new System.Windows.Forms.ComboBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbDinheiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCheckout = new System.Windows.Forms.ComboBox();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.gbxCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCaixa
            // 
            this.gbxCaixa.Controls.Add(this.cbxCheckout);
            this.gbxCaixa.Controls.Add(this.lblCheckout);
            this.gbxCaixa.Controls.Add(this.tbDinheiro);
            this.gbxCaixa.Controls.Add(this.label3);
            this.gbxCaixa.Controls.Add(this.tbSaldoAtual);
            this.gbxCaixa.Controls.Add(this.label2);
            this.gbxCaixa.Controls.Add(this.cbxOperador);
            this.gbxCaixa.Controls.Add(this.lblOperador);
            this.gbxCaixa.Location = new System.Drawing.Point(12, 12);
            this.gbxCaixa.Name = "gbxCaixa";
            this.gbxCaixa.Size = new System.Drawing.Size(201, 354);
            this.gbxCaixa.TabIndex = 0;
            this.gbxCaixa.TabStop = false;
            this.gbxCaixa.Text = "Caixa";
            this.gbxCaixa.Enter += new System.EventHandler(this.gbxCaixa_Enter);
            // 
            // tbSaldoAtual
            // 
            this.tbSaldoAtual.Location = new System.Drawing.Point(73, 79);
            this.tbSaldoAtual.MaxLength = 10;
            this.tbSaldoAtual.Name = "tbSaldoAtual";
            this.tbSaldoAtual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSaldoAtual.Size = new System.Drawing.Size(122, 20);
            this.tbSaldoAtual.TabIndex = 6;
            this.tbSaldoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalAt0_KeyPress);
            this.tbSaldoAtual.Leave += new System.EventHandler(this.tbSalAt0_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo Atual";
            // 
            // cbxOperador
            // 
            this.cbxOperador.FormattingEnabled = true;
            this.cbxOperador.Location = new System.Drawing.Point(73, 51);
            this.cbxOperador.Name = "cbxOperador";
            this.cbxOperador.Size = new System.Drawing.Size(122, 21);
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
            this.tbDinheiro.Size = new System.Drawing.Size(122, 20);
            this.tbDinheiro.TabIndex = 8;
            this.tbDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDinheiro_KeyPress);
            this.tbDinheiro.Leave += new System.EventHandler(this.tbDinheiro_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dinheiro";
            // 
            // cbxCheckout
            // 
            this.cbxCheckout.FormattingEnabled = true;
            this.cbxCheckout.Location = new System.Drawing.Point(73, 23);
            this.cbxCheckout.Name = "cbxCheckout";
            this.cbxCheckout.Size = new System.Drawing.Size(122, 21);
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
            // frmConfCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 416);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSaldoAtual;
        private System.Windows.Forms.TextBox tbDinheiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCheckout;
        private System.Windows.Forms.Label lblCheckout;
    }
}