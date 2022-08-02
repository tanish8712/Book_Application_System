using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Application_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tBOOK SYSTEM APPLICATION");
            Console.WriteLine("----------------------------------------------------------");
            do
            {
                Console.WriteLine("\t\t\t**MENU**\n");
                Console.WriteLine("Choose an option from the given Menu");
                Console.WriteLine("1 - Group All the Books According to their Self Number");
                Console.WriteLine("2 - Display Books according to the self ");
                Console.WriteLine("3 - Display all the available Books in the BOOK SYSTEM");
                Console.WriteLine("4 - EXIT from Application");
                Console.Write("\nSelect one Option : ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        var result1 = from p in Publisher.Getallpublisger()
                                      join b in Books.GetBooks()
                                      on p.Publishercode equals b.ID into grp
                                      select new
                                      {
                                          publish = p,
                                          book = grp
                                      };

                        foreach (var pub in result1)
                        {
                            Console.WriteLine("With Code : {0} Publisher is - {1}", pub.publish.Publishercode, pub.publish.Publisher_Name);
                            Console.WriteLine("Writer of Code {1} Book is : {0} ", pub.publish.AuthorName, pub.publish.Publishercode);
                            foreach (var b in pub.book)
                            {
                                Console.WriteLine("-->" + b.Book_name);
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        var result2 = from p in Books.GetBooks()
                                      group p by p.self_no;
                        foreach (var i in result2)
                        {
                            Console.WriteLine("Book_Self_no --> {0} Count : {1}", i.Key, i.Count());
                            Console.WriteLine("------");
                            foreach (var j in i)
                            {
                                Console.WriteLine("Name - {0}", j.Book_name);
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        var result3 = from x in Books.GetBooks()
                                      select x;
                        Console.WriteLine("Available Books are : \n");
                        foreach (var a in result3)
                        {
                            Console.WriteLine(a.Book_name);
                            Console.WriteLine("Total No. of Pages : {0}\n", a.Page_no);
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                }

            } while (true);
        }
    }
}
