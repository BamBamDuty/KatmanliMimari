using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto.LK;
using DogalGaz.Domain.Entities.Entities.LK;
using DogalGaz.Domain.Entities.Request.LK;
using DogalGaz.Domain.Services.Lookups.LKSobaMarka;
using Microsoft.AspNetCore.Mvc;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SobaMarkaController : BaseController<ISobaMarkaServices, SobaMarka, SobaMarkaDto, SobaMarkaRequest>
    {
       
        public SobaMarkaController(ISobaMarkaServices sobaMarka) : base(sobaMarka)
        {

        }

 
    }
}
