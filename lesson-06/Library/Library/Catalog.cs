using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Catalog
    {
        private Dictionary<string, Book> _catalogIsbn = new();

        //public int Count { get { return _catalog.Count; } }
        public int Count => _catalogIsbn.Count;

        public void Add(Book book)
        {
            _catalogIsbn.Add(book.Isbn, book);
            //_catalog[book.Isbn] = book;
        }


        public bool TryAdd(Book book)
        {
            return _catalogIsbn.TryAdd(book.Isbn, book);            
        }

        public (bool, Book) FindByIsbn(string isbn)
        {
            //exception if not found
            // return _catalog[isbn];

            if (_catalogIsbn.ContainsKey(isbn)) 
            {
                return (true, _catalogIsbn[isbn]);
            }
            else
            {
                return (false, null);
            }
        }

        /*public List<Book> FindByAuthor(Person author)
        {

        }
        */

        public List<Book> FindByTitle(string title)
        {
            var lst = new List<Book>();
            foreach (var item in _catalogIsbn)
            {
                if( item.Value.Title == title)
                {
                    lst.Add(item.Value);
                }
            }

            return lst;            
        }

        public List<Book> FindByTitleContains(string title)
        {
            var lst = new List<Book>();
            foreach (var item in _catalogIsbn)
            {
                if (item.Value.Title.Contains(title))
                {
                    lst.Add(item.Value);
                }
            }

            return lst;
        }

    }
}
