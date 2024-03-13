using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList_1._3
{
    public class Book
    {
        private string Name { get; set; }
        private string Author { get; set; }
        private int YearOfIssue { get; set; }

        public Book(string name , string author, int yearOfIssue)
        {
            this.Name = name;
            this.Author = author;
            this.YearOfIssue = yearOfIssue;
        }
    }
}
