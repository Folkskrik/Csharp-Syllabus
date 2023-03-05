using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");

                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                }
            }
        }

        private static void ListInventory()
        {
            _videoStore.ListInventory();
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < _countOfMovies; i++)
            {
                Console.WriteLine("Enter movie name");
                string movieName = Console.ReadLine();

                Console.WriteLine("Enter rating");
                int rating = Convert.ToInt32(Console.ReadLine());

                _videoStore.AddVideo(movieName);
                _videoStore.TakeUsersRating(rating, movieName);
            }
        }

        private static void RentVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            bool isRented = _videoStore.Checkout(movieName);

            if (isRented)
            {
                Console.WriteLine("Movie has been successfully rented");
            }
            else
            {
                Console.WriteLine("Movie is not available for renting");
            }
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            bool isReturned = _videoStore.ReturnVideo(movieName);

            if (isReturned)
            {
                Console.WriteLine("Movie has been successfully returned");
            }
            else
            {
                Console.WriteLine("Invalid movie name");
            }
        }
    }
}