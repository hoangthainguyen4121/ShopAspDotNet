using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAspDotNet.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        // TIPS: 1 Class kế thừa được Nhiều [Interface], nhưng chỉ kế thừa được từ 1 [Abstract] class

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        [MaxLength(256)]
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
