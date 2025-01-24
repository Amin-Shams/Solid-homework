using System;
using System.Collections.Generic;

namespace ReviewSystem
{
    class Program
    {
        static void ShowDatabase(List<Review> database){
            foreach (var review in database)
            {
                Console.WriteLine("database:");
                Console.WriteLine(review + "\n");


            }

        }
        static void Main(string[] args)
        {
            
            var database = new List<Review>();
            var submitReview = new SubmitReview(new Review(1, 101, 1001, "Great book!", 5));
            var editReview = new EditReview(1, "Absolutely loved it!", 5);
            var deleteReview = new DeleteReview(1);

            // confirm ro reject
            Console.WriteLine("Admin: Do you approve the submission? (yes/no)");
            bool isSubmissionApproved = Console.ReadLine()?.ToLower() == "yes";
            submitReview.Execute(database, isSubmissionApproved);
            ShowDatabase(database);
            Console.WriteLine("Admin: Do you approve the edit? (yes/no)");
            bool isEditApproved = Console.ReadLine()?.ToLower() == "yes";
            editReview.Execute(database, isEditApproved);
            ShowDatabase(database);
            Console.WriteLine("Admin: Do you approve the deletion? (yes/no)");
            bool isDeleteApproved = Console.ReadLine()?.ToLower() == "yes";
            deleteReview.Execute(database, isDeleteApproved);

            // final database
            Console.WriteLine("\nFinal Database:");
            ShowDatabase(database);
            Console.ReadLine();
        }
    }
}
