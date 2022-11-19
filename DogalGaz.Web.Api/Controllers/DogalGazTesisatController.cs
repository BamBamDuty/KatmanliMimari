using BaseController.Controller;
using DogalGaz.Domain.Entities.Dto;
using DogalGaz.Domain.Entities.Entities.LK;
using DogalGaz.Domain.Entities.Request;
using DogalGaz.Domain.Services.LKDogalGazTesisati;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogalGaz.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogalGazTesisatController : BaseController<IDogalGazTesisatServices, DogalGazTesisat, DogalGazTesisatDto, DogalGazTesisatRequest>
    {
        public DogalGazTesisatController(IDogalGazTesisatServices dogalGazTesisat) : base(dogalGazTesisat)
        {
        }
    }
}
