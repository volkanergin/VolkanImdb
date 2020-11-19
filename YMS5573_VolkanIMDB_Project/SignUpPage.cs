using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete;

namespace YMS5573_VolkanIMDB_Project
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        EfAccountRepository efAccountRepository = new EfAccountRepository();

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A confirmation e-mail has been sent to your e-mail address. Please verify your e-mail to complete your registration.");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignUpPage.ActiveForm.Hide();
            
            SignInPage signInPage = new SignInPage();
            signInPage.Show();
        }
    }
}
