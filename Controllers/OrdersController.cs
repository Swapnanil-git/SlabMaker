using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlabMaker.Data;
using System.Threading.Tasks;

namespace SlabMaker.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var orders = await _context.Orders.Where(o=>o.Status=="Open").ToListAsync();
            return View(orders);
        }
    }
}
