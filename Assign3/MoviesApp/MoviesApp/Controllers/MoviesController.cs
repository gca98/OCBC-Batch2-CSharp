using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MoviesApp.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace MoviesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MoviesController : ControllerBase
    {
        private MoviesContext _context;
        public MoviesController(MoviesContext context)
        {
            _context = context;
        }
        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<ItemData>> GetMovieAll()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetAllMovies();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] ItemData movie)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
                _context.InsertMovie(movie);
                return new JsonResult("Insert " + movie.Name);
            }
            else
            {
                return new JsonResult("ERROR");
            }
        }

        [HttpGet("{id}",Name = "Get By Id")]
        public ActionResult<IEnumerable<ItemData>> GetMovieId(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetMoviesById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> editMovie(int id,[FromBody] ItemData movie)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
                _context.UpdateMovie(id, movie);
                return new JsonResult("Update " +id + " "+ movie.Name);
            }
            else
            {
                return new JsonResult("ERROR");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> HapusMovie(int id)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
                _context.DeleteMovie(id);
                return new JsonResult("Delete " + id );
            }
            else
            {
                return new JsonResult("ERROR");
            }
        }
    }
}