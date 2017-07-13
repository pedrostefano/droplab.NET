using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droplab_DATA.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column("ID")]
        public long Id { get; set;}

    }
}
