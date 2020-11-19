using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Enums;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Repositories.Abstraction
{
    public interface IImdbUserRepository
    {
        void AddUser(string firstName, string lastName, string userName, string password, Role role);
        void UpdateUser(int id, string firstName, string lastName, string userName, string password, Role role);
        void DeleteUser(int id);

        void FindById(int id, TextBox txtFirstName, TextBox txtLastName, TextBox txtUserName, TextBox txtPassword);

        List<ImdbUser> GetActiveUser();
        List<ImdbUser> GetAll();
        List<ImdbUser> FindByName(string firstName);

        void GetRole(ComboBox comboBoxAdd, ComboBox comboBoxUpdate, ComboBox comboBoxFind);

        List<ImdbUser> ListbyRole(Role role);

        List<ImdbUser> GetByCreateDate(DateTime startDate, DateTime endDate);
    }
}
