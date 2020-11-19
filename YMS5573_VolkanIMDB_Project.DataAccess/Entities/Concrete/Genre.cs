using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete
{
    [Table("Genres")]
    public class Genre : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }

}
