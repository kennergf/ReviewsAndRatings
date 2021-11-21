using System;

namespace ReviewsAndRatings.Models
{
    public class WebsiteFeedback
    {
        public Guid Id {get;set;}
        
        public Guid IdCompany {get;set;}

        public Guid IdCustomer {get;set;}

        public string Feedback { get; set; }
    }
}