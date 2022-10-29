using BlazorWeb.Server.Data;
using BlazorWeb.Server.Model;
using BlazorWeb.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private MusicContext musicContext;


        public TrackController(MusicContext musicContext)
        {
            this.musicContext = musicContext;
        }

        [HttpGet("{id}")]
        public IEnumerable<TrackResponse> GetTracksForAlbum(int id)
        {
            var q = from t in musicContext.Track
                    where t.AlbumId == id
                    select new TrackResponse(t.Name, t.TrackId);


            return q.ToList();
        }
    }
}
