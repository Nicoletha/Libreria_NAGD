using System.Collections.Generic;

namespace Libreria_NAGD.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Propiedades de navegacion
        public List<Book_Author> Book_Author { get; set; }
    }
}
