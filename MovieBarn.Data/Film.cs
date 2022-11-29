using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBarn.Data
{
    public class Film : BaseEntity
    {
        public string Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public List<Genre>? Genres { get; set; }
    }
}
