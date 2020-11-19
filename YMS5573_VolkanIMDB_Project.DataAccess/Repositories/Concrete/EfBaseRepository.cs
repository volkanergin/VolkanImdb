using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_VolkanIMDB_Project.DataAccess.Context;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete
{
    public class EfBaseRepository
    {
        public IMDBProjectContext db;

        public EfBaseRepository()
        {
            db = new IMDBProjectContext();
        }
    }
}
