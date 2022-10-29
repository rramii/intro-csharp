using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWeb.Shared
{
    public record SearchResponse(string Artist, int Id);

    public record AlbumsResponse(string Title, int Id);
    
}
