using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBarn.Common.Models
{
    public class FilmVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        [DisplayName("Short description")]
        public string? ShortDescription { get; set; }

        [DisplayName("Long description")]
        public string? LongDescription { get; set; }

        public List<GenreVM>? Genres { get; set; }
    }
}
