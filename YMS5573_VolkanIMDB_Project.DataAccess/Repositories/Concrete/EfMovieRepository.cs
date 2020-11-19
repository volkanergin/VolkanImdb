using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Enums;
using YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Abstraction;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete
{
    public class EfMovieRepository : EfBaseRepository, IMovieRepository, IBaseRepository
    {
        Movie movie = new Movie();

        public void AddMovie(string title, string content, string pictureUrl, int genreId, int imdbUserId)
        {
            movie.Title = title;
            movie.Content = content;
            movie.ImageUrl = pictureUrl;
            movie.GenreId = genreId;
            movie.ImdbUserId = imdbUserId;
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        public Movie MovieDetails(int id)
        {
            return db.Movies.Include("Genre").Include("ImdbUser").FirstOrDefault(x => x.Id == id);
        }

        public void DeleteMovie(int id)
        {
            movie = db.Movies.FirstOrDefault(x => x.Id == id);
            movie.DeleteDate = DateTime.Now;
            movie.Status = Status.Passive;
            db.SaveChanges();
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public List<ImdbUser> GetActiveDirector()
        {
            return db.ImdbUsers.Where(x => x.Role == Role.Director && x.Status != Status.Passive).ToList();
        }

        public List<Movie> GetInTheatersMovie()
        {
            return db.Movies.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<Genre> GetActiveGenre()
        {
            return db.Genres.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public void UpdateMovie(int id, string title, string content, string pictureUrl, int genreId, int imdbUserId)
        {
            movie = db.Movies.FirstOrDefault(x => x.Id == id);
            movie.Title = title;
            movie.Content = content;
            movie.ImageUrl = pictureUrl;
            movie.GenreId = genreId;
            movie.ImdbUserId = imdbUserId;
            movie.Status = Status.Updated;
            movie.UpdateDate = DateTime.Now;
            db.SaveChanges();
        }
    }
}
