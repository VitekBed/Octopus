using Microsoft.AspNetCore.Mvc;

namespace OctopusCore.Srv
{
    public class OctopusController : Controller
    {
        [HttpPost("/get")]
        [HttpGet("/get")]
        public string Entry([FromBody] string value)
        {
            return Depot.Enter(value);    
        }
    }
}
