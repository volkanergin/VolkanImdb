using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public int ImdbUserId { get; set; }
        public virtual ImdbUser ImdbUser { get; set; }
    }
}
