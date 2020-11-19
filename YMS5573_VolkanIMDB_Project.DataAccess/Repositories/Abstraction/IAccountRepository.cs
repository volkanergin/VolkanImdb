using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Abstraction
{
    public interface IAccountRepository
    {
        void CreateCredentials(string firstName, string lastName, string userName, string password);

        bool CheckCredentials(string userName, string password);

        ImdbUser FindByUserName(string userName);
    }
}
