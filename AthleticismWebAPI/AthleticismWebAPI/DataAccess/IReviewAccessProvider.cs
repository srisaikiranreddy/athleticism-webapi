using System;
using System.Collections.Generic;
using AthleticismWebAPI.Models;

namespace AthleticismWebAPI.DataAccess
{
    public interface IReviewAccessProvider
    {
        void AddReviewRecord(Review review);
        void UpdateReviewRecord(Review review);
        void DeleteReviewRecord(int id);
        Review GetReviewSingleRecord(int id);
        List<Review> GetReviewRecords();
    }
}
