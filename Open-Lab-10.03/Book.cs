using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._03
{
    public class Book
    {
        private string title;
        private string author;
        private string category;
        private int pages;
        private int releaseDate;

        public string Title
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value > 2021)
                {
                    releaseDate = -1;
                }
                else if (value < 1450)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
        public string Print
        {
            get { return $" Title is: {Title}\n Author: {Author}\n Release date: {ReleaseDate}\n Category of the book: {Category}\n Number of pages: {Pages}"; }
        }
    }
}
