using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewsAndRatings.DTO;

namespace ReviewsAndRatings.Interfaces
{
    public interface IEstablishmentService
    {
        Task<List<EstablishmentReviewDTO>> GetReview(Guid IdEstablishment);

        Task<EstablishmentReviewDTO> CreateReview(EstablishmentReviewDTO establishmentReview);
    }
}