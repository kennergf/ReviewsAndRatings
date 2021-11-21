using System;
using System.ComponentModel.DataAnnotations;
using ReviewsAndRatings.Enums;

namespace ReviewsAndRatings.DTO
{
    public class EstablishmentReviewCreateDTO : EstablishmentReviewDTO
    {
        [Required]
        public Rating Rating { get; set; }

        public string WebsiteFeedback { get; set; }
    }
}