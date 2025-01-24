using System;
using System.Collections.Generic;

namespace ReviewSystem
{
    public interface ISubmit : IOperation { }
    public class SubmitReview : ISubmit
    {
        private readonly Review _review;

        public SubmitReview(Review review)
        {
            _review = review;
        }

        public void Execute(List<Review> database, bool isAdminApproved)
        {
            if (isAdminApproved)
            {
                database.Add(_review);
                Console.WriteLine($"Review { _review.Id } has been added to the database.");
            }
            else
            {
                Console.WriteLine($"Review { _review.Id } submission was rejected by the admin.");
            }
        }
    }

}
