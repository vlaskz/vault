using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace Vault
{
    public partial class vaultTBox : TextBox
    {
       

        

        public vaultTBox(string text)
        {
            Text = text; //construtor com parametro string
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            BackColor = Color.LightCyan;

        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            BackColor = Color.White;
        }

        

    }
}
