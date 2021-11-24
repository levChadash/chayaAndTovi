using BL;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApiSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        IManagerBL managerbl;

        public ManagerController(IManagerBL managerbl)
        {
            this.managerbl = managerbl;
        }

        // GET api/<user>/5
        [HttpGet("{managerName}/{password}")]
        public async Task<ActionResult<Manager>> Get(string managerName, string password)
        {

            Manager m = await managerbl.GetManager(managerName, password);
            if (m != null)
                return m;
            return NoContent();
        }


        // PUT api/<user>/5
        [HttpPut("{ManagerName}/{password}/{NewPassword}")]
        public void Put(string managerName, string password, string newPassword)
        {
            managerbl.PutManager(managerName, password, newPassword);
        }


    }
}
