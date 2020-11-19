using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Abstraction;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Enums;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Entities.Concrete
{
    public class BaseEntity : IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get {return _status;} set { _status = value;} }

    }
}
