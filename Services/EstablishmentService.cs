using System;
using System.Threading.Tasks;
using ReviewsAndRatings.DTO;
using ReviewsAndRatings.Interfaces;

namespace ReviewsAndRatings.Services
{
    public class EstablishmentService : IEstablishmentService
    {
        public Task<EstablishmentReviewDTO> GetReview(Guid IdEstablishment)
        {
            return Task.FromResult(new EstablishmentReviewDTO{Id = Guid.NewGuid()});
        }
    }
}