using Microsoft.AspNetCore.Mvc;
using SyncronApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SyncronApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetOwnCompany : ControllerBase
    {
        // GET: api/<GetOwnCompany>
        [HttpGet]
        public OwnCompany Get()
        {

            //TODO megírni az egészet
            Address address = new Address(Guid.NewGuid(), "Magyar", "Bács", "Kecskemét", "Kecske köz", "1","6000");
            Workers worker = new Workers(Guid.NewGuid(), "Betti", address, "Betti@", "0630");
            var ownCompany = new OwnCompany(Guid.NewGuid(), "Pisticég"/*, Guid.NewGuid()*/, worker); 
         
            return ownCompany;
        }
    }
}
