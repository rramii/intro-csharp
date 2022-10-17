using BlazorWeb.Server.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {

        private MusicContext musicContext;


        public AlbumsController(MusicContext musicContext)
        {
            this.musicContext = musicContext;
        }

        // GET: api/<Albums>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Albums>/5
        [HttpGet("{id}")]
        public List<string> Get(int id)
        {
            var albums = from artist in musicContext.Artist
                    where artist.ArtistId == id
                    select artist.Album;
            
            if (albums == null)
            {
                return new();
            }
            var result = from a in albums.Single()
                    select a.Title;
            return result.ToList();            
        }

        // POST api/<Albums>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Albums>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Albums>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
