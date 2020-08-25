using DataControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please input Username and Password");
            }
            else
            {
                IUserValidation loginValidation = new UserLoginAccess();

                if (loginValidation.UserValidate(txtusername.Text, txtpassword.Text))
                {
                    MessageBox.Show("Welcome " + txtusername.Text);
                    this.Hide();
                    Index if2 = new Index();
                    if2.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
