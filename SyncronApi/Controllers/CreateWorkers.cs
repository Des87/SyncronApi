using Microsoft.AspNetCore.Mvc;
using SyncronApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SyncronApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateWorkers : ControllerBase
    {
        // PUT api/<CreateWorkers>/5
        [HttpPut]
        public void Put(Workers worker/*, [FromBody] string value*/)
        {
            //TODO ellenőrizni, hogy van e ilyen Id-vel rendelkező Workers
            //TODO létrehozni az új Workers-t
            //TODO Lementeni adatbázisba
        }
    }
}
