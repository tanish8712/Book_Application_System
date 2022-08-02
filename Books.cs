using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Application_System
{
    public class Books
    {
        public int ID { get; set; }
        public int self_no { get; set; }
        public string Book_name { get; set; }
        public int Page_no { get; set; }
        public static List<Books> GetBooks()
        {
            List<Books> book = new List<Books>
            {
                new Books {ID = 1, self_no = 1, Page_no = 455, Book_name = "THINK LIKE A MONK"},
                new Books {ID = 2, self_no = 2, Page_no = 239, Book_name = "DEEP WORK"},
                new Books {ID = 3, self_no = 3, Page_no = 290, Book_name = "ATOMIC HABITS"},
                new Books {ID = 4, self_no = 1, Page_no = 189, Book_name = "THINK AND GROW RICH"},
                new Books {ID = 5, self_no = 1, Page_no = 249, Book_name = "FIVE POINT SOMEONE"},
                new Books {ID = 6, self_no = 2, Page_no = 345, Book_name = "THE GOLDEN GATE"}
            };
            return book;
        }
    }
}
