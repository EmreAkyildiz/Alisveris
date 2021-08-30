using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusterisController : Controller
    {
        IMusteriService _musteriService;

        public MusterisController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        [HttpPost("add")]
        public IActionResult Add(Musteri musteri)
        {
            var result = _musteriService.Add(musteri);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("sehiranaliz")]
        public IActionResult SehirBazliAnalizYap()
        {
            var result = _musteriService.SehirBazliAnalizYap();
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
