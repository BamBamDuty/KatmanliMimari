using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto.LK;
using DogalGaz.Domain.Entities.Entities.LK;
using DogalGaz.Domain.Entities.Request.LK;
using DogalGaz.Domain.Services.Lookups.LKSobaModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SobaModelController : BaseController<ISobaModelServices, SobaModel, SobaModelDto, SobaModelRequest>
    {
        private readonly ISobaModelServices _sobaModel;

        public SobaModelController(ISobaModelServices sobaModel) : base(sobaModel)
        {
            _sobaModel = sobaModel;
        }

        [HttpGet]
        [Route("GetSobaModelBySobaMarkaId")]
        public IQueryable<SobaModel> GetSobaModelBySobaMarkaId([FromQuery] int sobaMarkaId)
        {
            return _sobaModel.GetSobaModelBySobaMarkaId(sobaMarkaId);
        }
    }
}
