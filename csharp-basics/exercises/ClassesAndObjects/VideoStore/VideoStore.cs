using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> inventory;
        public VideoStore()
        {
            inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            Video video = new Video(title);
            inventory.Add(video);
            Console.WriteLine($"{title} has been added to the inventory.");
        }

        public bool Checkout(string title)
        {
            Video video = inventory.Find(v => v.Title == title);
            if (video != null && video.Available())
            {
                video.BeingCheckedOut();
                inventory.Remove(video);
                return true;
            }
            else
            {
                Console.WriteLine($"{title} not found in the inventory or is not available for rent.");
                return false;
            }
        }

        public bool ReturnVideo(string title)
        {
            Video video = inventory.Find(v => v.Title == title);
            if (video != null)
            {
                return video.BeingReturned();
            }
            else
            {
                Console.WriteLine($"{title} not found in the inventory.");
                return false;
            }
        }

        public void TakeUsersRating(int rating, string title)
        {
            Video video = inventory.Find(v => v.Title == title);
            if (video != null)
            {
                video.ReceivingRating(rating);
            }
            else
            {
                Console.WriteLine($"{title} not found in the inventory.");
            }
        }

        public void ListInventory()
        {
            foreach (Video video in inventory)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}