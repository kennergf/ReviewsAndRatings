using System;
using ReviewsAndRatings.Enums;

namespace ReviewsAndRatings.Models
{
    public class WebsiteFeedbackReview
    {
        public Guid Id {get;set;}
        public Guid IdCompany {get;set;}
        public Guid IdCustomer {get;set;}
        public Rating Rating { get; set; }
        public string Feedback { get; set; }
    }
}