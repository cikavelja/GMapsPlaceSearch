using GMapsPlaceSearch.Data;
using GMapsPlaceSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GMapsPlaceSearch.Controllers
{
    public class RealEstateController : ApiController
    {
        // GET: api/RealEstate
        public Models.Request Get()
        {
            Models.Request req = new Request();
            req.street = "58 North Terrace";
            return req;
        }

        public async Task<IQueryable<RealEstate>> Post([FromBody]Models.Request parameter)
        {
            string[] POAddressArray = await Task.Run(() => parameter.street.Split(','));;
            string POAddress = POAddressArray[POAddressArray.Count() - 2];
            string qstring = POAddress.Substring(POAddress.Count() - 7, 5);
            var sdata = SampleData.Get();
            var filtereddata = from q in SampleData.Get() where q.Street.Contains(qstring) select q;
            return filtereddata.AsQueryable();
        }
    }
}
