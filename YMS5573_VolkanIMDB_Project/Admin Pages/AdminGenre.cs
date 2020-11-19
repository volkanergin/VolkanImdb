using System;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete;

namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    public partial class AdminGenre : Form
    {
        public AdminGenre()
        {
            InitializeComponent();
        }

        EfGenreRepository efGenreRepository = new EfGenreRepository();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            efGenreRepository.CreateGenre(txtCreateName.Text);
            dataGridView1.DataSource = efGenreRepository.GetActiveGenre();
            efGenreRepository.Eraser(grpCreateGenre);
        }

        private void AdminGenre_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenreRepository.GetActiveGenre();

        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            efGenreRepository.FindById(int.Parse(txtFindById.Text), txtUpdateName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            efGenreRepository.UpdateGenre(int.Parse(txtFindById.Text), txtUpdateName.Text);
            efGenreRepository.Eraser(grpUpdateGenre);
            dataGridView1.DataSource = efGenreRepository.GetActiveGenre();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            efGenreRepository.DeleteGenre(int.Parse(txtDeleteGenre.Text));
            efGenreRepository.Eraser(grpDelete);
            dataGridView1.DataSource = efGenreRepository.GetActiveGenre();
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenreRepository.FindByName(txtFindByName.Text);
            efGenreRepository.Eraser(grpFindByName);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenreRepository.GetAll();
        }
    }
}
