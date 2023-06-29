using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2Hastane.model
{
    public class Randevular
    {
        [Key]
        public int RandevuId { get; set; }

        [StringLength(50), Required]
        public string HastaAdiSoyadi { get; set; }
        public string BolumAdi { get; set; }
        public string DoktorAdSoyad { get; set; }
        [Required]
        [StringLength(11)]
        public string RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        
    }
}

