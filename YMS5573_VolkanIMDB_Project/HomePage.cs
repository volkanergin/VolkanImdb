using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5573_VolkanIMDB_Project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            HomePage.ActiveForm.Hide();
            
            SignInPage signInPage = new SignInPage();
            signInPage.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            HomePage.ActiveForm.Hide();

            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
        }
    }
}
