using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.Admin_Pages;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Enums;
using YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete;

namespace YMS5573_VolkanIMDB_Project
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        EfAccountRepository efAccountRepository = new EfAccountRepository();
        
        private void btnSıgnIn_Click(object sender, EventArgs e)
        {
            efAccountRepository.CheckCredentials(txtUsername.Text, txtPassword.Text);

            ImdbUser user = efAccountRepository.FindByUserName(txtUsername.Text);

            if (user.Role == Role.Admin)
            {
                SignInPage.ActiveForm.Hide();

                AdminHome adminHome = new AdminHome();
                adminHome.Show();

            }
            else if (user.Role == Role.User)
            {
                SignInPage.ActiveForm.Hide();

                MemberHome memberHome = new MemberHome();
                memberHome.Show();                
            }
            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please enter valid credentials..!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInPage.ActiveForm.Hide();
            
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            SignInPage.ActiveForm.Hide();

            RecoverPassword recoverPassword = new RecoverPassword();
            recoverPassword.Show();
        }
    }
}
