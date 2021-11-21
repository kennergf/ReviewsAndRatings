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
    public class EstablishmentReviewRepository : Repository<EstablishmentReview>, IEstablishmentReviewRepository
    {
        public EstablishmentReviewRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<List<EstablishmentReview>> GetNotApproved()
        {
            return await _db.EstablishmentReview.Where(c => c.Approved == false).ToListAsync();
        }
    }
}