using System;
using System.ComponentModel.DataAnnotations;
using ReviewsAndRatings.Enums;

namespace ReviewsAndRatings.DTO
{
    public class EstablishmentReviewDTO
    {
        [Required]
        public Guid IdEstablishment {get;set;}

        [Required]
        public Guid IdCustomer {get;set;}

        public string Review { get; set; }
    }
}