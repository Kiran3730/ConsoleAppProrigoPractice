using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Assignment
{
  public class Book
    {
        private int BookId { get; set; }
        private string BookName { get; set; }

        private string AutherName { get; set; }
        private int Price { get; set; }
        
      

        public Book(int BookId, string BookName,string AutherName, int Price)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            this.AutherName = AutherName;
            this.Price = Price;
        }
        public override string ToString()
        {
            return BookId+" "+BookName+" "+AutherName+" "+Price;

        }



}

}
