using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPLearning.Controls.Session5.Navigation.Demo3
{
    public class BookInfo
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

        public BookInfo(string bookName, string author, string price, string image)
        {
            this.BookName = bookName;
            this.Author = author;
            this.Price = price;
            this.Image = image;
        }
    }
}
