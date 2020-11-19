using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Enums;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete
{
    [Table("ImdbUsers")]
    public class ImdbUser : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
