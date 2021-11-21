using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReviewsAndRatings.Models;

namespace ReviewsAndRatings.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ReviewsAndRatings.Models.EstablishmentReview> EstablishmentReview { get; set; }
        public DbSet<ReviewsAndRatings.Models.WebsiteFeedback> WebsiteFeedback { get; set; }
    }
}
