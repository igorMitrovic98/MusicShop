using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopMuzickeOpreme.Forms;
using ShopMuzickeOpreme.Controllers;


namespace ShopMuzickeOpreme
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //jezik
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isClicked = false;
        private void btnEye_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                textPassword.PasswordChar = '*';
                isClicked = !isClicked;
            }
            else
            {
                textPassword.PasswordChar = '\0';
                isClicked = ! isClicked;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

        }
    }
}
