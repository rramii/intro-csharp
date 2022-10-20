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
        public IEnumerable<TrackResponse> Get(int id)
        {
            var q = from Track in musicContext.Track
                    where Track.TrackId == id
                    select new TrackResponse(Track.Name, Track.TrackId);


            return q.ToList();
        }
    }
}
