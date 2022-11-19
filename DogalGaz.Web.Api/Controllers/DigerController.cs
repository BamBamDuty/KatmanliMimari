using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto.LK;
using DogalGaz.Domain.Entities.Entities.LK;
using DogalGaz.Domain.Entities.Request.LK;
using DogalGaz.Domain.Services.Lookups.LKDiger;
using Microsoft.AspNetCore.Mvc;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigerController : BaseController<IDigerServices, Diger, DigerDto, DigerRequest>
    {
        public DigerController(IDigerServices diger):base(diger)
        {
        }

    }
}
