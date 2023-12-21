using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesObjects
{
    internal class Book
    {
        //Atributtes - thi is a specefication what is a book
        public string title;
        public string autor;
        public int pages;

        //Constructors
        //aTitle = argument tittle..
        public Book(string aTitle, string aAuthor, int aPages) 
        {
            title = aTitle;
            autor = aAuthor;
            pages = aPages;
        }

    }

}
