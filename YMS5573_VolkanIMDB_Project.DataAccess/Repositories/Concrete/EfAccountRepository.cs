using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;
using YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Abstraction;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Concrete
{
    public class EfAccountRepository : EfBaseRepository, IAccountRepository, IBaseRepository
    {
        ImdbUser imdbUser = new ImdbUser();

        public bool CheckCredentials(string userName, string password)
        {
            return db.ImdbUsers.Any(x => x.UserName == userName && x.Password == password);
        }

        public void CreateCredentials(string firstName, string lastName, string userName, string password)
        {
            imdbUser.FirstName = firstName;
            imdbUser.LastName = lastName;
            imdbUser.UserName = userName;
            imdbUser.Password = password;
            imdbUser.Role = Entities.Enums.Role.User;
            db.ImdbUsers.Add(imdbUser);
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

        public ImdbUser FindByUserName(string userName)
        {
            return db.ImdbUsers.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
