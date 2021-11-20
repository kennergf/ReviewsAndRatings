using System;
using System.Threading.Tasks;
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

        //[Authorize]
        [HttpGet("[action]")]
        public async Task<ActionResult<EstablishmentReviewDTO>> GetReview([FromQuery] Guid IdEstablishment)
        {
            var result = await _establishmentService.GetReview(IdEstablishment);
            return result;
        }

        //[Authorize]
        [HttpPost("[action]")]
        public async Task<ActionResult<EstablishmentReviewDTO>> CreateReview(EstablishmentReviewDTO establishmentReviewDTO)
        {
            // if (!ModelState.IsValid) return ModelState;

            // await _establishmentService.Add(establishmentReviewDTO);
            // // TODO return something more meaningful
            // return CustomResponse(establishmentReviewDTO);
            return null;
        }
    }
}