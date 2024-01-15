using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetAllMovie();
        }

        //POST: api/User
        [HttpPost]
        public ActionResult<IEnumerable<MovieItem>> PostMovieItem(MovieItem item)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
                _context.PostMovieItem(item);
                return new JsonResult(item) { StatusCode = 200 };
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        //PUT: api/User/{id}
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<MovieItem>> UpdateMovieItem(int id, [FromBody] MovieItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            List<MovieItem> existItem = new List<MovieItem>(_context.GetMovie(id));

            try
            {
                if (id != item.id)
                {
                    return BadRequest();
                }

                else if (!existItem.Any())
                {
                    return NotFound();
                }
                else
                {
                    _context.UpdateMovieItem(id, item);
                    return new JsonResult(item) { StatusCode = 200 };
                }
            }

            catch (Exception e)
            {
                return new JsonResult(e) { StatusCode = 500 };
            }

        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<MovieItem>> DeleteMovieItem(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            List<MovieItem> existItem = new List<MovieItem>(_context.GetMovie(id));

            try
            {
                if (!existItem.Any())
                {
                    return NotFound();
                }
                else
                {
                    _context.DeleteMovieItem(id);
                    return new JsonResult("Success delete " + id) { StatusCode = 200 };
                }
            }

            catch (Exception e)
            {
                return new JsonResult(e) { StatusCode = 500 };
            }

        }


        // GET: api/user/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems(int id)
        {

            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            List<MovieItem> existItem = new List<MovieItem>(_context.GetMovie(id));
            if (!existItem.Any())
            {
                return NotFound();
            }
            else
            {
                return new JsonResult(_context.GetMovie(id)) { StatusCode = 200 };
            }
        }
    }
}