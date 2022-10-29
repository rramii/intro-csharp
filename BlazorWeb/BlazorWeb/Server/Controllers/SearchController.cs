using BlazorWeb.Server.Data;
using BlazorWeb.Server.Model;
using BlazorWeb.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private MusicContext musicContext;

        public SearchController(MusicContext musicContext)
        {
            this.musicContext = musicContext;
        }

        [HttpGet("{Name}")]
        public IEnumerable<SearchResponse> GetArtistWith(string Name)
        {
            var q = from artist in musicContext.Artist
                    where artist.Name.Contains(Name)
                    select new SearchResponse(artist.Name, artist.ArtistId);


            return q.ToList();
        }

        //[HttpGet("{Name}")]
        //public List<string> GetName(string Name)
        //{
        //    var z = from artist in musicContext.Artist
        //            where artist.Name.Contains(Name)
        //            select artist.Name;

        //    return z.ToList<string>();
        //}
    }
}
