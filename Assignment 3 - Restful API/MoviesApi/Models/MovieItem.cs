using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Models
{
    public class MovieItem
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string genre { get; set; }
        [Required]
        public string duration { get; set; }
        [Required]
        public string releaseDate { get; set; }
    }
}
