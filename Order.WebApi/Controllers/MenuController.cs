using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Persistence;
using Order.Persistence.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Order.WebApi.Controllers
{
    [Route("api/Menu")]
    public class MenuController:Controller
    {
        private readonly PizzaOrderContext _context;
        public MenuController(PizzaOrderContext context)
        {
            _context = context;
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddNewMenuItem([FromBody] MenuDTO item)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                if (_context.Menu.Any(i => i.Name.Equals(item.Name)))
                    return BadRequest();

                var newMenuItem = new Menu()
                {
                    Name = item.Name,
                    Category = (_context.Category.Where(o => o.ID == item.CategoryID+1)).FirstOrDefault(),
                    Description = item.Description,
                    Price = item.Price,
                    Spicy= item.Spicy,
                    Vegetarian = item.Vegetarian,
                    Count=0
                };

                _context.Menu.Add(newMenuItem);

                _context.SaveChanges();
                
            }
            catch (DbUpdateConcurrencyException)
            {
               return BadRequest();
            }
            catch (DbUpdateException)
            {
                return BadRequest();
            }

            return Ok();
        }
        
        [HttpGet("MenuList")]
        public IActionResult List()
        {
            try
            {
                return Ok(_context.Menu.ToList().Select(MenuItem => new MenuDTO
                {
                    ID = MenuItem.ID,
                    Name = MenuItem.Name,
                    Description = MenuItem.Description,
                    Price = MenuItem.Price,
                    Vegetarian = MenuItem.Vegetarian,
                    Spicy = MenuItem.Spicy
                }));
            }
            catch
            {
                // Internal Server Error
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
