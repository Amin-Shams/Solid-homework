using System;
using System.Collections.Generic;

namespace ReviewSystem
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        public Review(int id, int bookId, int customerId, string content, int rating)
        {
            Id = id;
            BookId = bookId;
            CustomerId = customerId;
            Content = content;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"Review {Id}: {Content} (Rating: {Rating})";
        }
    }

}
