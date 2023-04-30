using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

using static System.Environment;

namespace csharp_biblioteca
{
    public class Item
    {
       string productCode; 
       string title;
       string year;
       string genre;
       string position;
       string author;

        public Item(string productCode, string title, string year, string genre, string position, string author){
            this.productCode = productCode;
            this.title = title;
            this.year = year;
            this.genre = genre;
            this.position = position;
            this.author = author;
        }

        public override string ToString()
        {
            return $"product code: {productCode}" + NewLine
                    + $"title: {title}" + NewLine
                    + $"year: {year}" + NewLine
                    + $"genre: {genre}" + NewLine
                    + $"position: {position}" + NewLine
                    + $"author: {author}";
        }
    }

    public class Book : Item
    {
        int pages;

        public Book(string productCode, string title, string year, string genre, string position, string author, int pages) : base(productCode, title, year, genre, position, author)
        {
            this.pages = pages;
        }

        public override string ToString()
        {
            return base.ToString() + NewLine
                + $"pages: {pages}";
        }
    }

    public class DVD : Item
    {
        int time;

        public DVD(string productCode, string title, string year, string genre, string position, string author, int time) : base(productCode, title, year, genre, position, author)
        {
            this.time = time;
        }

        public override string ToString()
        {
            return base.ToString() + NewLine
                + $"time: {time}";
        }
    }
}