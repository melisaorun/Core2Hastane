using Core2Hastane.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2Hastane.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public virtual DbSet<Doktorlar>Doktorlar { get; set; }
        public virtual DbSet<Hastalar> Hastalar { get; set; }
        public virtual DbSet<Randevular> Randevular { get; set; }
        public virtual DbSet<Poliklinikler> Poliklinikler { get; set; }
    }
}
