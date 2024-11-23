using System.Collections.Generic;

namespace Libreria_NAGD.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }
    public class PublisherWithBooksAndAutorsVM
    {
        public string Name { get; set; }
        public List<BookAutorVM> BookAuthors { get; set; }
    }
    public class BookAutorVM
    {
        public string BooksName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}
