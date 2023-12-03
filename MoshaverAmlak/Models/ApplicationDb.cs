using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshaverAmlak.Models
{
    public class ApplicationDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=Database.db"); //*options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AmlakDB;Integrated Security=True");*/

        public DbSet<Property> Properties { get; set; }
        public DbSet<SoldedProperty> SoldedProperties { get; set; }
    }
}
