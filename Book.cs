using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRconstraction
{
    internal class Book
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value > 0 && value <= 5000 ? value : 0; }
        }
        public Book (string title , int pages)
        {
            Title = title;
            Pages = pages;
        }
        public Book(string title): this (title,100)
        {

        }
        public Book() : this("Unkown", 1)
        {

        }
        public void Read()
        {
            Console.WriteLine($"Читаю книгу: {title}, страниц: {pages}");
        }
    }
}
