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
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private readonly PizzaOrderContext _context;
        public CategoryController(PizzaOrderContext context)
        {
            _context = context;
        }
        
        [HttpGet("CategoryList")]
        public IActionResult List()
        {
            try
            {
                return Ok(_context.Category.ToList().Select(CategoryItem => new CategoryDTO
                {
                    ID = CategoryItem.ID,
                    Name = CategoryItem.Name

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
