using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Abstraction
{
    public interface IMovieRepository
    {
        void AddMovie(string title, string content, string pictureUrl, int genreId, int appUserId);
        void UpdateMovie(int id, string title, string content, string pictureUrl, int genreId, int appUserId);
        void DeleteMovie(int id);

        List<Movie> GetInTheatersMovie();
        List<Movie> GetAll();
        Movie MovieDetails (int id);

        List<Genre> GetActiveGenre();
        List<ImdbUser> GetActiveDirector();
    }
}
