using Microsoft.AspNetCore.Mvc;
using SyncronApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SyncronApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateContacts : ControllerBase
    {

        private readonly Localdb _LocalDb;
        public CreateContacts(Localdb localDb)
        {
            this._LocalDb = localDb;
        }
        // PUT api/<CreateContacts>/5
        [HttpPut]
        public void Put(User user/*, [FromBody] string value*/)
        {
            var newcompany = new User(user.Id, user.Name/*, company.Address*/);

     //       _LocalDb.SaveChanges();
            //TODO ellenőrizni, hogy van e ilyen Id-vel rendelkező Companies
            //TODO létrehozni az új Companies-t
            //TODO Lementeni adatbázisba
        }
    }
}
