using GMapsPlaceSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMapsPlaceSearch.Data
{
    public class SampleData
    {
        public static List<RealEstate> Get()
        {
            List<RealEstate> data = new List<RealEstate>();
            data.Add(new RealEstate { Id = 1, HouseNum = 1, Street = "62/378 Beaufort St, Perth WA 6000, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 2, HouseNum = 1, Street = "938 Hay St, Perth WA 6000, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 3, HouseNum = 1, Street = "2 Delhi St, West Perth WA 6005, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 4, HouseNum = 1, Street = "342 Newcastle St, Perth WA 6000, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 5, HouseNum = 1, Street = "1/27 Military Rd, West Beach SA 5024, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 6, HouseNum = 1, Street = "61/378 Beaufort St, Perth WA 6000, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 7, HouseNum = 1, Street = "Western Youth Centre, 79 Marion Rd, Cowandilla SA 5033, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 8, HouseNum = 1, Street = "201-203 Richmond Road, Richmond SA 5033, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 9, HouseNum = 1, Street = "Westfield Marion, Marion Shopping Centre, 297 Diagonal Road, Oaklands Park SA 5046, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 10, HouseNum = 1, Street = "9 Strangways Ave, Hayborough SA 5211, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 11, HouseNum = 1, Street = "72 Seagull Ave, Hayborough SA 5211, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 12, HouseNum = 1, Street = "58 North Terrace, Port Elliot SA 5212, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 13, HouseNum = 1, Street = "11 Mason St, Port Elliot SA 5212, Australia", City = "", Suburb = "", State = "" });
            data.Add(new RealEstate { Id = 13, HouseNum = 1, Street = "972 Wellington St, West Perth WA 6005, Australia", City = "", Suburb = "", State = "" });
            return data;
            //972 Wellington St, West Perth WA 6005, Australia
        }
    }
}