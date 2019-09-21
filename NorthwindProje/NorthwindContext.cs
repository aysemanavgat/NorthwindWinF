using NorthwindProje.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProje
{
    public class NorthwindContext : DbContext
    { /*mapping yapmadığımızda products tablosuna direk bağlayacaktır
        aksini belirtmediğimiz sürece */
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
