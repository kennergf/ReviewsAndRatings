using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewsAndRatings.DTO;
using ReviewsAndRatings.Interfaces;

namespace ReviewsAndRatings.Controllers
{
    [ApiController]
    [Route("api/Establishment")]
    public class EstablishmentController : ControllerBase
    {
        private readonly IEstablishmentService _establishmentService;

        public EstablishmentController(IEstablishmentService establishmentService)
        {
            _establishmentService = establishmentService;
        }

        [AllowAnonymous]
        [HttpGet("[action]")]
        public async Task<ActionResult<List<EstablishmentReviewDTO>>> GetReview([FromQuery] Guid IdEstablishment)
        {
            var result = await _establishmentService.GetReview(IdEstablishment);
            return new JsonResult(result);
        }

        [Authorize]
        [HttpPost("[action]")]
        public async Task<ActionResult<EstablishmentReviewDTO>> CreateReview(EstablishmentReviewCreateDTO establishmentReviewDTO)
        {
            // Validate Model
            if (!ModelState.IsValid) return new BadRequestObjectResult(ModelState);

            var result = await _establishmentService.CreateReview(establishmentReviewDTO);
            return new CreatedResult(new Uri("/CreateReview"), result);
        }
    }
}