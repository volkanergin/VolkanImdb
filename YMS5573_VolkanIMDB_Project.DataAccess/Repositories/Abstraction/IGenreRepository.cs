using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Abstraction
{
    public interface IGenreRepository
    {
        void CreateGenre(string name);
        void UpdateGenre(int id, string name);
        void DeleteGenre(int id);
        void FindById(int id, TextBox textBox);

        List<Genre> GetActiveGenre();
        List<Genre> FindByName(string name);
        List<Genre> GetAll();
    }
}
