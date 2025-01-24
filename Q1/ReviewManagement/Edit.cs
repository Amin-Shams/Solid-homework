using System;
using System.Collections.Generic;

namespace ReviewSystem
{
     public interface IEdit : IOperation { }
    public class EditReview : IEdit
    {
        private readonly int _reviewId;
        private readonly string _newContent;
        private readonly int _newRating;

        public EditReview(int reviewId, string newContent, int newRating)
        {
            _reviewId = reviewId;
            _newContent = newContent;
            _newRating = newRating;
        }

        public void Execute(List<Review> database, bool isAdminApproved)
        {
            if (isAdminApproved)
            {
                var review = database.Find(r => r.Id == _reviewId);
                if (review != null)
                {
                    review.Content = _newContent;
                    review.Rating = _newRating;
                    Console.WriteLine($"Review {_reviewId} has been updated.");
                }
                else
                {
                    Console.WriteLine($"Review {_reviewId} not found in the database.");
                }
            }
            else
            {
                Console.WriteLine($"Review {_reviewId} edit was rejected by the admin.");
            }
        }
    }
}


