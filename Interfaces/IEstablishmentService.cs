using System;
using System.Threading.Tasks;
using ReviewsAndRatings.DTO;

namespace ReviewsAndRatings.Interfaces
{
    public interface IEstablishmentService
    {
        Task<EstablishmentReviewDTO> GetReview(Guid IdEstablishment);
    }
}