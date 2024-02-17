using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
namespace Order.Persistence
{
    public class DBInitializer
    {
        private static Panasz[] _category;
        private static PizzaOrderContext _context;
        public static void Initialize(PizzaOrderContext context)
        {
            _context = context;
            context.Database.EnsureCreated();
            if (!_context.Panaszok.Any())
            {
                SeedOrder();
            }

           
            _context.SaveChanges();
        }
       
        private static void SeedOrder()
        {
            _category = new Panasz[]
            {
                new Panasz
                {
                   ManName="Desszertek",
                    ManAddress="Desszertek",
                    fail="Desszertek",
                    time=DateTime.MinValue
                },
                new Panasz
                {
                    ManName="Desszertek",
                    ManAddress="Desszertek",
                    fail="Desszertek",
                    time=DateTime.Now
                },
                new Panasz
                {
                    ManName="Desszertek",
                    ManAddress="Desszertek",
                    fail="Desszertek",
                    time=DateTime.Today
                }

            };

            foreach (Panasz c in _category)
            {
                _context.Panaszok.Add(c);
            }
            _context.SaveChanges();
        }
        
       
    }
}
