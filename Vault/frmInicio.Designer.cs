﻿namespace Vault
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o módulo desejado:";
            // 
            // btnConfCaixa
            // 
            this.btnConfCaixa.Location = new System.Drawing.Point(41, 82);
            this.btnConfCaixa.Name = "btnConfCaixa";
            this.btnConfCaixa.Size = new System.Drawing.Size(146, 47);
            this.btnConfCaixa.TabIndex = 1;
            this.btnConfCaixa.Text = "Conferência de Caixa";
            this.btnConfCaixa.UseVisualStyleBackColor = true;
            this.btnConfCaixa.Click += new System.EventHandler(this.btnConfCaixa_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 156);
            this.Controls.Add(this.btnConfCaixa);
            this.Controls.Add(this.label1);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfCaixa;
    }
}