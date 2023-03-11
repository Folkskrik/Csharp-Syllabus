using System;
using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string title;
        private bool isCheckedOut;
        private double totalRating;
        private int ratingCount;

        public Video(string title)
        {
            this.title = title;
            isCheckedOut = false;
            totalRating = 0;
            ratingCount = 0;
        }

        public bool BeingCheckedOut()
        {
            if (isCheckedOut)
            {
                Console.WriteLine(title + " is already checked out.");
                return false;
            }
            else
            {
                isCheckedOut = true;
                Console.WriteLine(title + " has been checked out.");
                return true;
            }
        }

        public bool BeingReturned()
        {
            if (isCheckedOut)
            {
                isCheckedOut = false;
                Console.WriteLine(title + " has been returned.");
                return true;
            }
            else
            {
                Console.WriteLine(title + " was not checked out.");
                return false;
            }
        }

        public void ReceivingRating(int rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                totalRating += rating;
                ratingCount++;
                Console.WriteLine($"Received rating {rating} for {title}");
            }
            else
            {
                Console.WriteLine("Invalid rating. Please provide a number between 1 and 5.");
            }
        }

        public double AverageRating()
        {
            if (ratingCount == 0)
            {
                return 0;
            }
            else
            {
                return totalRating / ratingCount;
            }
        }

        public bool Available()
        {
            return !isCheckedOut;
        }

        public string Title => title;

        public override string ToString()
        {
            return $"{Title} rating {AverageRating()} is {(Available() ? "available" : "checked out")}";
        }
    }
}