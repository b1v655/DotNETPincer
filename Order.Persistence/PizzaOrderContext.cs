using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Order.Persistence
{
    public class PizzaOrderContext : IdentityDbContext<Employee>
    {
        public PizzaOrderContext(DbContextOptions<PizzaOrderContext> options)
            : base(options)
        {
        }

        public DbSet<Panasz> Panaszok { get; set; }

    }
}
