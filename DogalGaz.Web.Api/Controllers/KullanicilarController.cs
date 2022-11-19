using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.Kullanicilar_;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullanicilarController : BaseController<IKullanicilarServices, Kullanicilar, KullanicilarDto,KullanicilarRequest>
    {

        public KullanicilarController(IKullanicilarServices kullanicilar): base(kullanicilar)
        {
        }

    }
}
