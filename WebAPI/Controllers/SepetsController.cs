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
    public class SepetsController : Controller
    {
        ISepetService _sepetService;

        public SepetsController(ISepetService sepetService)
        {
            _sepetService = sepetService;
        }

        [HttpPost("add")]
        public IActionResult Add(Sepet sepet)
        {
            var result = _sepetService.Add(sepet);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
