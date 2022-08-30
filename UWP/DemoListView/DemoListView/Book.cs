using System.Collections.Generic;

namespace DemoListView
{
    public class Book
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Year { get; set; }

        public List<Book> GetDateSample()
        {
            return new List<Book>
            {
                new Book
                {
                    Name = "Universal Window Platform",
                    Year = 2015,
                    ImagePath = "/Assets/Book/uwp.png"
                },
                new Book
                {
                    Name = "Sql Server",
                    Year = 2002,
                    ImagePath = "/Assets/Book/sql.png"
                },
                new Book
                {
                    Name = "PHP",
                    Year = 2015,
                    ImagePath = "/Assets/Book/php.png"
                },
                new Book
                {
                    Name = "Java Core 1",
                    Year = 1995,
                    ImagePath = "/Assets/Book/java1.png"
                },
                new Book
                {
                    Name = ".Net Framework",
                    Year = 2000,
                    ImagePath = "/Assets/Book/netFrame.png"
                }
            };
        }
    }
}