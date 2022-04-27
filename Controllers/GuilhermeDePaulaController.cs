using API_Andreia_Leles.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Andreia_Leles.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuilhermeDePaulaController : ControllerBase
    {
        [HttpGet("Guima")]
        public Macena Get()
        {
            Macena macena = new Macena
            {
                PhoneNumber = "(15)98172-3980",
                DickSize = 16
            };

            return macena;
        }

        [HttpGet("Paula")]
        public Macena GetPau()
        {
            Macena macena = new Macena
            {
                PhoneNumber = "(15)98172-3980",
                DickSize = 18
            };

            return macena;
        }


    }
}
