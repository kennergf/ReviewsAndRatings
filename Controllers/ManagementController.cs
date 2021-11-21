using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReviewsAndRatings.Data;
using ReviewsAndRatings.Interfaces;
using ReviewsAndRatings.Models;

namespace ReviewsAndRatings.Controllers
{
    public class ManagementController : Controller
    {
        private readonly IEstablishmentService _establishmentService;
        private readonly ApplicationDbContext _context;

        public ManagementController(IEstablishmentService establishmentService, ApplicationDbContext context)
        {
            _establishmentService = establishmentService;
            _context = context;
        }

        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        // GET: Management
        public async Task<IActionResult> Index()
        {
            var result = await _establishmentService.GetReview(System.Guid.NewGuid());
            return View(await _context.EstablishmentReview.ToListAsync());
        }

        // GET: Management/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var establishmentReview = await _context.EstablishmentReview.FindAsync(id);
            if (establishmentReview == null)
            {
                return NotFound();
            }
            return View(establishmentReview);
        }

        // POST: Management/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,IdEstablishment,IdCustomer,Rating,Review,Approved")] EstablishmentReview establishmentReview)
        {
            if (id != establishmentReview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(establishmentReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstablishmentReviewExists(establishmentReview.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(establishmentReview);
        }

        private bool EstablishmentReviewExists(Guid id)
        {
            return _context.EstablishmentReview.Any(e => e.Id == id);
        }
    }
}
