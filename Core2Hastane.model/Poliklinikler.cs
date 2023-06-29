using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2Hastane.model
{
    public class Poliklinikler
    {
        [Key]
        public int BolumId { get; set; }

        [StringLength(50), Required]
        public string BolumAdi { get; set; }
        public string DoktorAdSoyad { get; set; }
        [ForeignKey("Doktorlar")]
        public int DoktorId { get; set; }
        public virtual Doktorlar Doktorlar { get; set; }

        
    }
}
