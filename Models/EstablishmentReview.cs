using System;
using ReviewsAndRatings.Enums;

namespace ReviewsAndRatings.Models
{
    public class EstablishmentReview
    {
        public Guid Id {get;set;}
        public Guid IdEstablishment {get;set;}
        public Guid IdCustomer {get;set;}
        public Rating Rating { get; set; }
        public string Review { get; set; }
        public bool Approved { get; set; }
    }
}