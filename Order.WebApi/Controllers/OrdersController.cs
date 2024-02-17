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
    [Route("api/Orders")]
    public class OrdersController : Controller
    {
        private readonly PizzaOrderContext _context;
        public OrdersController(PizzaOrderContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> IsAccomplished([FromBody] PanaszDTO item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newMenuItem = new Panasz()
                    {
                        ManName = item.ManName,
                        ManAddress = item.ManAddress,
                        fail = item.fail,
                        time = DateTime.Now,
                        IsOk = false

                    };

                    _context.Panaszok.Add(newMenuItem);

                    _context.SaveChanges();

                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                BadRequest();
            }
            return Ok();
        }
        [HttpGet("OrdersList")]
        public IActionResult List()
        {
            try
            {
                return Ok(_context.Panaszok.ToList().Select(OrdersItem => new PanaszDTO
                {
                    ID = OrdersItem.ID,
                    ManName = OrdersItem.ManName,
                    ManAddress = OrdersItem.ManAddress,
                    fail = OrdersItem.fail,
                    time = OrdersItem.time,
                    IsOk =  OrdersItem.IsOk

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