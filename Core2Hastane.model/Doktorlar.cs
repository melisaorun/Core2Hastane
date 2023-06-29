using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2Hastane.model
{
    public class Doktorlar
    {
        [Key]
        public int DoktorId { get; set; }

        [StringLength(50),Required]
        public string DoktorAdSoyad { get; set; }
        public string Unvan { get; set; }
        [ForeignKey("Randevular")]
        public int RandevuId { get; set; }
        public virtual Randevular Randevular { get; set; }

    }
}
