using System;
using ReviewsAndRatings.Entities;
using ReviewsAndRatings.Enums;

namespace ReviewsAndRatings.Models
{
    public class EstablishmentReview : Entity
    {
        public Guid IdEstablishment {get;set;}
        public Guid IdCustomer {get;set;}
        public Rating Rating { get; set; }
        public string Review { get; set; }
        public bool Approved { get; set; }
    }
}