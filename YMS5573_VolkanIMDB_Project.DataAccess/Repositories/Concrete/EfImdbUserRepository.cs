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
    public class EfImdbUserRepository : EfBaseRepository, IImdbUserRepository, IBaseRepository
    {
        ImdbUser imdbUser = new ImdbUser();

        public void AddUser(string firstName, string lastName, string userName, string password, Role role)
        {
            imdbUser.FirstName = firstName;
            imdbUser.LastName = lastName;
            imdbUser.UserName = userName;
            imdbUser.Password = password;
            imdbUser.Role = role;
            db.ImdbUsers.Add(imdbUser);
            db.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            imdbUser = db.ImdbUsers.FirstOrDefault(x => x.Id == id);
            imdbUser.DeleteDate = DateTime.Now;
            imdbUser.Status = Status.Passive;
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

        public void FindById(int id, TextBox txtFirstName, TextBox txtLastName, TextBox txtUserName, TextBox txtPassword)
        {
            imdbUser = db.ImdbUsers.FirstOrDefault(x => x.Id == id);
            txtFirstName.Text = imdbUser.FirstName;
            txtLastName.Text = imdbUser.LastName;
            txtUserName.Text = imdbUser.UserName;
            txtPassword.Text = imdbUser.Password;
        }

        public List<ImdbUser> FindByName(string firstName)
        {
            return db.ImdbUsers.Where(x => x.FirstName.ToLower().Contains(firstName.ToLower())).ToList();
        }

        public List<ImdbUser> GetActiveUser()
        {
            return db.ImdbUsers.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<ImdbUser> GetAll()
        {
            return db.ImdbUsers.ToList();
        }

        public List<ImdbUser> GetByCreateDate(DateTime startDate, DateTime endDate)
        {
            return db.ImdbUsers.Where(x => x.CreateDate >= startDate && x.CreateDate <= endDate && x.Status != Status.Passive).ToList();
        }

        public void GetRole(ComboBox comboBoxAdd, ComboBox comboBoxUpdate, ComboBox comboBoxFind)
        {
            comboBoxAdd.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxAdd.SelectedIndex = 0;

            comboBoxUpdate.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxUpdate.SelectedIndex = 0;

            comboBoxFind.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxFind.SelectedIndex = 0;
        }

        public List<ImdbUser> ListbyRole(Role role)
        {
            return db.ImdbUsers.Where(x => x.Role == role && x.Status != Status.Passive).ToList();
        }

        public void UpdateUser(int id, string firstName, string lastName, string userName, string password, Role role)
        {
            imdbUser = db.ImdbUsers.FirstOrDefault(x => x.Id == id);
            imdbUser.FirstName = firstName;
            imdbUser.LastName = lastName;
            imdbUser.UserName = userName;
            imdbUser.Password = password;
            imdbUser.UpdateDate = DateTime.Now;
            imdbUser.Status = Status.Updated;
            imdbUser.Role = role;
            db.SaveChanges();
        }
    }
}
