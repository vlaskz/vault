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
            this.gbx0 = new System.Windows.Forms.GroupBox();
            this.tbSalAt0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOp0 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gbx0.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx0
            // 
            this.gbx0.Controls.Add(this.tbSalAt0);
            this.gbx0.Controls.Add(this.label2);
            this.gbx0.Controls.Add(this.cbxOp0);
            this.gbx0.Controls.Add(this.label1);
            this.gbx0.Location = new System.Drawing.Point(13, 13);
            this.gbx0.Name = "gbx0";
            this.gbx0.Size = new System.Drawing.Size(190, 478);
            this.gbx0.TabIndex = 0;
            this.gbx0.TabStop = false;
            this.gbx0.Text = "Caixa";
            // 
            // tbSalAt0
            // 
            this.tbSalAt0.Location = new System.Drawing.Point(73, 45);
            this.tbSalAt0.MaxLength = 10;
            this.tbSalAt0.Name = "tbSalAt0";
            this.tbSalAt0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSalAt0.Size = new System.Drawing.Size(112, 20);
            this.tbSalAt0.TabIndex = 6;
            this.tbSalAt0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalAt0_KeyPress);
            this.tbSalAt0.Leave += new System.EventHandler(this.tbSalAt0_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo Atual";
            // 
            // cbxOp0
            // 
            this.cbxOp0.FormattingEnabled = true;
            this.cbxOp0.Location = new System.Drawing.Point(73, 21);
            this.cbxOp0.Name = "cbxOp0";
            this.cbxOp0.Size = new System.Drawing.Size(112, 21);
            this.cbxOp0.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operador";
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
            this.ClientSize = new System.Drawing.Size(1260, 534);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbx0);
            this.Name = "frmConfCaixa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conferência de Caixa";
            this.Load += new System.EventHandler(this.frmConfCaixa_Load);
            this.gbx0.ResumeLayout(false);
            this.gbx0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx0;
        private System.Windows.Forms.ComboBox cbxOp0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSalAt0;
    }
}