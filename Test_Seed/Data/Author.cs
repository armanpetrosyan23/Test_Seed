using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Seed.Data
{
    public class Author
    {

        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Year { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
