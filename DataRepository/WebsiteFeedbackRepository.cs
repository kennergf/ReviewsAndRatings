using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReviewsAndRatings.Data;
using ReviewsAndRatings.Entities;
using ReviewsAndRatings.Interfaces;
using ReviewsAndRatings.Models;

namespace ReviewsAndRatings.DataRepository
{
    public class WebsiteFeedbackRepository : Repository<WebsiteFeedback>, IWebsiteFeedbackRepository
    {
        public WebsiteFeedbackRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}