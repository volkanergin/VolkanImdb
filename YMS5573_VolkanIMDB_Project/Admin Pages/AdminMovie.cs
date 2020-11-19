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

namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    public partial class AdminMovie : Form
    {
        public AdminMovie()
        {
            InitializeComponent();
        }

        EfMovieRepository efMovieRepository = new EfMovieRepository();
        
        private void AdminMovie_Load(object sender, EventArgs e)
        {
            cmbAddGenre.DataSource = efMovieRepository.GetActiveGenre();
            cmbAddGenre.DisplayMember = "Name";
            cmbAddGenre.ValueMember = "Id";
            cmbAddGenre.SelectedIndex = -1;

            cmbAddDirector.DataSource = efMovieRepository.GetActiveDirector();
            cmbAddDirector.DisplayMember = "Username";
            cmbAddDirector.ValueMember = "Id";
            cmbAddDirector.SelectedIndex = -1;

            dataGridView1.DataSource = efMovieRepository.GetInTheatersMovie();
        }

        string fileName;
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            ofdAddPicture.Filter = "JPG | *jpg";
            if (ofdAddPicture.ShowDialog() == DialogResult.OK)
            {
                txtAddPictureUrl.Text = ofdAddPicture.FileName;
                fileName = ofdAddPicture.FileName;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            efMovieRepository.AddMovie(txtAddTitle.Text, txtAddContext.Text, fileName, (int)cmbAddGenre.SelectedValue, (int)cmbAddDirector.SelectedValue);
            dataGridView1.DataSource = efMovieRepository.GetInTheatersMovie();
            efMovieRepository.Eraser(grpAddMovie);

        }

        public static int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            AdminMovieDetails adminMovieDetails = new AdminMovieDetails();
            adminMovieDetails.Show();
        }
    }
}
