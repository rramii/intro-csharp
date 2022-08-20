using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public record Book(string Title, string Isbn, List<Person> Authors, int Copies) { }
    
}
