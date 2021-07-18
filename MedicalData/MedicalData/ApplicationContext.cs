using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace MedicalData
{
    class ApplicationContext : DbContext
    {
        public DbSet<DateMeds> DateMed { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }
    }
}
