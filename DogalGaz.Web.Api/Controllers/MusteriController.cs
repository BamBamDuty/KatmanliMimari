using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.Musteri_;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : BaseController<IMusteriServices, Musteri, MusteriDto, MusteriRequest>
    {
        private readonly IMusteriServices _musteriServices;
        public MusteriController(IMusteriServices musteri) : base(musteri)
        {
            _musteriServices = musteri;
        }

        [HttpPut]
        [Route("Update2")]
        public async Task<Musteri> Update2([FromBody] MusteriRequest teklifRequest)
        {
            return await _musteriServices.Update2(teklifRequest);

        }

    }
}

