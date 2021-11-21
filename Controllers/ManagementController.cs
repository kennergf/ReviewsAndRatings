using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewsAndRatings.Interfaces;

namespace ReviewsAndRatings.Controllers
{
    public class ManagementController : Controller
    {
        private readonly IEstablishmentService _establishmentService;

        public ManagementController(IEstablishmentService establishmentService)
        {
            _establishmentService = establishmentService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _establishmentService.GetReview(System.Guid.NewGuid());
            return View(result);
        }
    }
}