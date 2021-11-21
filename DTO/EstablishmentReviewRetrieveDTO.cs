using System.ComponentModel.DataAnnotations;

namespace ReviewsAndRatings.DTO
{
    public class EstablishmentReviewRetrieveDTO : EstablishmentReviewDTO
    {
        [Required]
        public string Rating { get; set; }
    }
}