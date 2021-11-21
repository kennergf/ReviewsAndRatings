using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewsAndRatings.DTO;
using ReviewsAndRatings.Interfaces;

namespace ReviewsAndRatings.Services
{
    public class EstablishmentService : IEstablishmentService
    {
        public Task<List<EstablishmentReviewDTO>> GetReview(Guid IdEstablishment)
        {
            var result = new List<EstablishmentReviewDTO>();
            result.Add(new EstablishmentReviewRetrieveDTO
            {
                IdEstablishment = IdEstablishment,
                IdCustomer = Guid.NewGuid(),
                Rating = Enums.Rating.Good.ToString(),
                Review = "This is a mocked review!"
            });
            result.Add(new EstablishmentReviewRetrieveDTO
            {
                IdEstablishment = IdEstablishment,
                IdCustomer = Guid.NewGuid(),
                Rating = Enums.Rating.Good.ToString(),
                Review = "This is a mocked review!"
            });
            return Task.FromResult(result);
        }

        public Task<EstablishmentReviewDTO> CreateReview(EstablishmentReviewDTO establishmentReview)
        {
            return Task.FromResult(establishmentReview);
        }

    }
}