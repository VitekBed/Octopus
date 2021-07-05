using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OctopusCore.Srv
{
    public class OctopusController : Controller
    {
        [HttpPost("/get")]
        [HttpGet("/get")]
        public P Get ([FromBody] Q value)
        {
            return value.employees.ToArray()[1];
            //return Depot.Enter(value.ToString());    
        }
    }

    public struct Q
    {
        public List<P> employees { get; set; }
    }
    public struct P
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
