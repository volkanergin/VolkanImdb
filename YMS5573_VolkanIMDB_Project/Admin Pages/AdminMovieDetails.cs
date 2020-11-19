using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;
using YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete;

namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    public partial class AdminMovieDetails : Form
    {
        public AdminMovieDetails()
        {
            InitializeComponent();
        }


        EfMovieRepository efMovieRepository = new EfMovieRepository();

        int movieId = AdminMovie.id;

        private void AdminMovieDetails_Load(object sender, EventArgs e)
        {
            Movie movie = efMovieRepository.MovieDetails(movieId);
            lblId.Text = movie.Id.ToString();
            lblTitle.Text = movie.Title;
            lblContent.Text = movie.Content;
            lblGenre.Text = movie.Genre.Name;
            lblDirector.Text = movie.ImdbUser.UserName;
            pictureBox1.Image = Image.FromFile(movie.ImageUrl);
        }
    }
}
