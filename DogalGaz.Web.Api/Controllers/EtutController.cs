using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.Etut_;
using Microsoft.AspNetCore.Mvc;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtutController : BaseController<IEtutServices, Etut, EtutDto, EtutRequest>
    {
        public EtutController(IEtutServices etut) : base(etut)
        {
        }

    }
}
