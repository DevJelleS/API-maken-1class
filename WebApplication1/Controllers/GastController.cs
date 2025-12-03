using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GastController : Controller
    {
        [HttpGet("{id}")]
        public ActionResult<Gast> GetGast(int id)
        {
            return new Gast
            {
                GastID = id,
                VoorNaam = "Jan",
                Achternaam = "Jansen",
                Email = "jan@example.com",
                Telefoon = "0612345678",
                Adres = "Dorpsstraat 1",
                Postcode = "1234AB",
                Woonplaats = "Amsterdam",
                Land = "NL",
                Opmerking = "VIP-klant"
            };
        }

        [HttpPost]
        public ActionResult<Gast> CreateGast([FromBody] Gast gast)
        {
            return Ok(gast);
        }
    }
}
