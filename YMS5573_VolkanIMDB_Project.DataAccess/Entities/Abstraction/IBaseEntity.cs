using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_VolkanIMDB_Project.DataAccess.Entities.Enums;

namespace YMS5573_VolkanIMDB_Project.DataAccess.Entities.Abstraction
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime? UpdateDate { get; set; }
        DateTime? DeleteDate { get; set; }
        Status Status { get; set; }
    }
}
