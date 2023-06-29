using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2Hastane.model
{
    public class Hastalar
    {
        [Key]
        public int HastaId { get; set; }

        [StringLength(50), Required]
        public string HastaAdiSoyadi { get; set; }

        [Required]
        [StringLength(11)]
        public string HastaTC { get; set; }
        public string HastaDT { get; set; }
        [ForeignKey("Randevular")]
        public int RandevuId { get; set; }
        public virtual Randevular Randevular { get; set; }

    }
}
