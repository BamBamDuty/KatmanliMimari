using DogalGaz.Domain.Entities.Entities.LK;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.Radyator_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadyatorController : BaseController<IRadyatorServices, Radyator, RadyatorDto, RadyatorRequest>
    {

        public RadyatorController(IRadyatorServices radyator) : base(radyator)
        {
        }

        
    }
}