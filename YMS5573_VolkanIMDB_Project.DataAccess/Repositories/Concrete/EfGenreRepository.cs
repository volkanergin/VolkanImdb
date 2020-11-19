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
    public class EfGenreRepository : EfBaseRepository, IGenreRepository, IBaseRepository
    {
        Genre genre = new Genre();

        public void CreateGenre(string name)
        {
            genre.Name = name;
            db.Genres.Add(genre);
            db.SaveChanges();
        }

        public void DeleteGenre(int id)
        {
            try
            {
                genre = db.Genres.FirstOrDefault(x => x.Id == id);
                genre.DeleteDate = DateTime.Now;
                genre.Status = Status.None;
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Please type into id information..!");
            }
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

        public void FindById(int id, TextBox textBox)
        {
            genre = db.Genres.FirstOrDefault(x => x.Id == id);
            textBox.Text = genre.Name;
        }

        public List<Genre> FindByName(string name)
        {
            return db.Genres.Where(x => x.Name.ToLower() == name.ToLower()).ToList();
        }

        public List<Genre> GetActiveGenre()
        {
            return db.Genres.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public void UpdateGenre(int id, string name)
        {
            genre = db.Genres.FirstOrDefault(x => x.Id == id);
            genre.Name = name;
            genre.UpdateDate = DateTime.Now;
            genre.Status = Status.Updated;
            db.SaveChanges();
        }
    }
}
