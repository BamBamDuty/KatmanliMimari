using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities.LK;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.Lookups.LKKombiMarka;
using Microsoft.AspNetCore.Mvc;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KombiMarkaController : BaseController<IKombiMarkaServices, KombiMarka, KombiMarkaDto, KombiMarkaRequest>
    {

        public KombiMarkaController(IKombiMarkaServices kombiMarka) : base(kombiMarka)
        {
            
        }


    }
}
