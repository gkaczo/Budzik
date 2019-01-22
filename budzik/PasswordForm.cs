using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace budzik
{
    public partial class PasswordForm : Form
    {
        private string strHaslo;

        public bool passwdOK;

        public PasswordForm()
        {
            InitializeComponent();
            strHaslo = "abc";
            passwdOK = false;
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            

            if (txtHaslo.Text == strHaslo)
            {
                passwdOK = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Zle haslo");
            }
            

        }
    }
}
