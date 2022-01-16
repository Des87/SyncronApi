using Microsoft.AspNetCore.Mvc;
using SyncronApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SyncronApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateCompanies : ControllerBase
    {
        private readonly Localdb _LocalDb;
        public CreateCompanies(Localdb localDb)
        {
            this._LocalDb = localDb;
        }

        // PUT api/<CreateCompanies>/5
        [HttpPut]
        public void Put(/*, [FromBody] string value*/)
        {
            //    var newcompany = new User(user.Id, user.Name/*, company.Address*/);

             //   _LocalDb.User.Add(newcompany);
            //    _LocalDb.SaveChanges();


        //    _LocalDb.User.Add(newcompany);
         //   _LocalDb.SaveChanges();

            //var t = _LocalDb.User.Where(p=>p.Name != null).ToList();
            //if (t != null)
            //{

            //}
                        //TODO ellenőrizni, hogy van e ilyen Id-vel rendelkező Companies
            //TODO létrehozni az új Companies-t
            //TODO Lementeni adatbázisba
        }
    }
}
