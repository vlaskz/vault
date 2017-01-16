namespace Vault
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo!\r\nSelecione o módulo desejado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfCaixa
            // 
            this.btnConfCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnConfCaixa.Image")));
            this.btnConfCaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfCaixa.Location = new System.Drawing.Point(12, 39);
            this.btnConfCaixa.Name = "btnConfCaixa";
            this.btnConfCaixa.Size = new System.Drawing.Size(138, 149);
            this.btnConfCaixa.TabIndex = 1;
            this.btnConfCaixa.Text = "Conferência de Caixa";
            this.btnConfCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfCaixa.UseVisualStyleBackColor = true;
            this.btnConfCaixa.Click += new System.EventHandler(this.btnConfCaixa_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 199);
            this.Controls.Add(this.btnConfCaixa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vault";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfCaixa;
    }
}