using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Droplab_DATA.Entities
{
    [Table("T_OS")]
    public class TOS : BaseEntity
    {
        [Required]
        [MaxLength(250)]
        [Column(name: "DESCRIPTION")]
        public string Description { get; set; }
        [Column(name: "DT_CREATED")]
        public DateTime CreatredDate { get; set; }
        [Column(name: "ID_MODIFIED")]
        public DateTime ModifiedDate { get; set; }
    }
}