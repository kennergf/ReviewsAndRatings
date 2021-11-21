using System;
using ReviewsAndRatings.Entities;

namespace ReviewsAndRatings.Models
{
    public class WebsiteFeedback : Entity
    {
        public Guid IdCompany {get;set;}

        public Guid IdCustomer {get;set;}

        public string Feedback { get; set; }
    }
}