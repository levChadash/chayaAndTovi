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
        IManagerBL Managerbl;

        public ManagerController(IManagerBL Managerbl)
        {
            this.Managerbl = Managerbl;
        }

        // GET api/<user>/5
        [HttpGet("{ManagerName}/{password}")]
        public async Task<ActionResult<Manager>> Get(string ManagerName, string password)
        {

            Manager m = await Managerbl.getManager(ManagerName, password);
            if (m != null)
                return m;
            return NoContent();
        }


        // PUT api/<user>/5
        [HttpPut("{ManagerName}/{password}/{NewPassword}")]
        public void Put(string ManagerName, string password, string NewPassword)
        {
            Managerbl.putManager(ManagerName, password, NewPassword);
        }


    }
}
