using System;
using System.Collections.Generic;

namespace ReviewSystem
{
    public interface IDelete : IOperation { }

    public class DeleteReview : IDelete
    {
        private readonly int _reviewId;

        public DeleteReview(int reviewId)
        {
            _reviewId = reviewId;
        }

        public void Execute(List<Review> database, bool isAdminApproved)
        {
            if (isAdminApproved)
            {
                var review = database.Find(r => r.Id == _reviewId);
                if (review != null)
                {
                    database.Remove(review);
                    Console.WriteLine($"Review {_reviewId} has been deleted from the database.");
                }
                else
                {
                    Console.WriteLine($"Review {_reviewId} not found in the database.");
                }
            }
            else
            {
                Console.WriteLine($"Review {_reviewId} deletion was rejected by the admin.");
            }
        }
    }
}