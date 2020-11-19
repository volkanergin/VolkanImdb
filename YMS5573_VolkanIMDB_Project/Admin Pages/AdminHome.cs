using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnMovieManagement_Click(object sender, EventArgs e)
        {
            AdminMovie adminMovie = new AdminMovie();
            adminMovie.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            AdminImdbUser adminImdbUser = new AdminImdbUser();
            adminImdbUser.Show();
        }

        private void btnGenreManagement_Click(object sender, EventArgs e)
        {
            AdminGenre adminGenre = new AdminGenre();
            adminGenre.Show();
        }

        private void btnAdminLogOut_Click(object sender, EventArgs e)
        {
            AdminHome.ActiveForm.Close();
        }
    }
}
