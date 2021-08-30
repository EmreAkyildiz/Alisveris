using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriSepetsController : Controller
    {
        IMusteriSepetService _musterisepetservice;
        public MusteriSepetsController(IMusteriSepetService musterisepetService)
        {
            _musterisepetservice = musterisepetService;
        }
        [HttpPost("test")]
        public IActionResult TestVerisiOlustur(int musteriAdet, int sepetAdet)
        {
            var result = _musterisepetservice.TestVerisiOlustur(musteriAdet,sepetAdet);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
