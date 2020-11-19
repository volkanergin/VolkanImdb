using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Enums;
using YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete;

namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    public partial class AdminImdbUser : Form
    {
        public AdminImdbUser()
        {
            InitializeComponent();
        }

        EfImdbUserRepository efImdbUserRepository = new EfImdbUserRepository();
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            efImdbUserRepository.AddUser(txtAddFirstName.Text, txtAddLastName.Text, txtAddUserName.Text, txtAddPassword.Text, (Role)Enum.Parse(typeof(Role), cmbAddRole.Text));
            dataGridView1.DataSource = efImdbUserRepository.GetActiveUser();
            efImdbUserRepository.Eraser(grpAddUser);
        }

        private void AdminImdbUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efImdbUserRepository.GetActiveUser();
            efImdbUserRepository.GetRole(cmbAddRole, cmbUpdateRole, cmbFindByRole);
        }

        private void btnFindId_Click(object sender, EventArgs e)
        {
            efImdbUserRepository.FindById(int.Parse(txtFindById.Text), txtUpdateFirstName, txtUpdateLastName, txtUpdateUserName, txtUpdatePassword);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            efImdbUserRepository.UpdateUser(
                int.Parse(txtFindById.Text),
                txtUpdateFirstName.Text,
                txtUpdateLastName.Text,
                txtUpdateUserName.Text,
                txtUpdatePassword.Text,
                (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text));
            dataGridView1.DataSource = efImdbUserRepository.GetActiveUser();
            efImdbUserRepository.Eraser(grpUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            efImdbUserRepository.DeleteUser(int.Parse(txtDeleteById.Text));
            dataGridView1.DataSource = efImdbUserRepository.GetActiveUser();
            efImdbUserRepository.Eraser(grpDelete);

        }

        private void cmbFindByRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efImdbUserRepository.ListbyRole((Role)Enum.Parse(typeof(Role), cmbFindByRole.Text));
        }
    }
}
