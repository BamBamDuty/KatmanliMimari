using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities.LK;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KombiModelController : BaseController<IKombiModelServices, KombiModel, KombiModelDto, KombiModelRequest>
    {
        private readonly IKombiModelServices _kombiModel;

        public KombiModelController(IKombiModelServices kombiModel) : base(kombiModel)
        {
            _kombiModel = kombiModel;
        }

        [HttpGet]
        [Route("GetKombiModelByKombiMarkaId")] 
        public IQueryable<KombiModel> GetKombiModelByKombiMarkaId([FromQuery] int kombiMarkaId)
        {
            return _kombiModel.GetKombiModelByKombiMarkaId(kombiMarkaId);
        }       

    }
}
