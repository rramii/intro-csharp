using BlazorWeb.Server.Data;
using BlazorWeb.Shared;
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
        public List<AlbumsResponse> GetAlbumsByArtist(int id)
        {
            var albums = from a in musicContext.Album
                    where a.ArtistId == id
                    select new AlbumsResponse(a.Title, a.AlbumId);
            
            return albums.ToList();            
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
