using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Application_System
{
    public class Publisher
    {
        public int Publishercode { get; set; }
        public string Publisher_Name { get; set; }
        public string AuthorName { get; set; }

        public static List<Publisher> Getallpublisger()
        {
            List<Publisher> pub = new List<Publisher>
            {
                new Publisher { Publishercode = 1, Publisher_Name = "Thorsons", AuthorName = "Jay Shetty"},
                new Publisher { Publishercode = 2, Publisher_Name = "Grand Central Publishing", AuthorName = "Cal Newport"},
                new Publisher { Publishercode = 3, Publisher_Name = "PenguinRandomHouse", AuthorName = "James Clear"},
                new Publisher { Publishercode = 4, Publisher_Name = "Simon & Schuster", AuthorName = "Napoleon Hill"},
                new Publisher { Publishercode = 5, Publisher_Name = "Piatkus Books", AuthorName = "Chetan Bhagat"},
                new Publisher { Publishercode = 6, Publisher_Name = "Indian Paper", AuthorName = "Vikram Seth"}
            };
            return pub;
        }
    }
}
