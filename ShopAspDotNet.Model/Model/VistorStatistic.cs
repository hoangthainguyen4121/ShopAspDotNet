using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ShopAspDotNet.Model.Model
{
    [Table("VistorStatistics")]
    public class VistorStatistic
    {
        [Key]
        public Guid ID{ get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [MaxLength(50)]
        public string IPAdress{ get; set; }

    }
}
