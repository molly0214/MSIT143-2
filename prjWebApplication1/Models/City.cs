using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class City
    {
        public City()
        {
            Members = new HashSet<Member>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
