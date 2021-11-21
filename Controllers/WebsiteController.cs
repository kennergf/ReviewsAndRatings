using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReviewsAndRatings.Data;
using ReviewsAndRatings.Models;

namespace ReviewsAndRatings.Controllers
{
    public class WebsiteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WebsiteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Website
        public async Task<IActionResult> Index()
        {
            return View(await _context.WebsiteFeedback.ToListAsync());
        }
    }
}
