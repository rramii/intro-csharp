using BlazorWeb.Server.Data;
using BlazorWeb.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorWeb.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {

        private MusicContext musicContext;

  
        public ArtistsController(MusicContext musicContext)
        {
            this.musicContext = musicContext;
        }


        // GET:/<ArtistsController>
        [HttpGet]
        public IEnumerable<ArtistResponse> Get()
        {            
            var q = from artist in musicContext.Artist
                    where artist.Name.Length < 6
                    select new ArtistResponse()
                    {
                        Name = artist.Name,
                        Albums = artist.Album.Count
                    };

            return q.ToList();
        }

        // GET /<ArtistsController>/id
        [HttpGet("{id}")]
        public string Get(int id)
        {            
            var q = from artist in musicContext.Artist
                    where artist.ArtistId == id
                    select artist.Name;

            return q.FirstOrDefault();
        }

        // POST api/<ArtistsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArtistsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
    }
}
