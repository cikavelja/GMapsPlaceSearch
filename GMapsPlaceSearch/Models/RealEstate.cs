using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMapsPlaceSearch.Models
{
    public class RealEstate
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string  Suburb { get; set; }
        public string Street { get; set; }
        public int HouseNum { get; set; }
    }
}