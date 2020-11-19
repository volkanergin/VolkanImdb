using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Context
{
    public class IMDBProjectContext : DbContext
    {
        public IMDBProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=YMS5573_VolkanIMDB_Project;Integrated Security=True;";
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ImdbUser> ImdbUsers { get; set; }
    }
}
