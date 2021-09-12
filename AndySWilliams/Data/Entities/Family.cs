using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndySWilliams.Data.Entities
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }       
    }
}
