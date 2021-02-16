using System;
using System.Collections.Generic;
using System.Linq;
using AthleticismWebAPI.Models;

namespace AthleticismWebAPI.DataAccess
{
    public class ReviewAccessProvider:IReviewAccessProvider
    {
        private readonly PGDBContext _context;

        public ReviewAccessProvider(PGDBContext context)
        {
            _context = context;
        } 

        public void AddReviewRecord(Review review)
        {
            _context.reviews.Add(review);
            _context.SaveChanges();
        }

        public void UpdateReviewRecord(Review review)
        {
            _context.reviews.Update(review);
            _context.SaveChanges();
        }

        public void DeleteReviewRecord(int id)
        {
            var entity = _context.reviews.FirstOrDefault(t => t.id == id);
            _context.reviews.Remove(entity);
            _context.SaveChanges();
        }

        public Review GetReviewSingleRecord(int id)
        {
            return _context.reviews.FirstOrDefault(t => t.id == id);
        }

        public List<Review> GetReviewRecords()
        {
            return _context.reviews.ToList();
        }
    }
}
