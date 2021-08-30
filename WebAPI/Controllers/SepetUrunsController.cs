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
    public class SepetUrunsController : Controller
    {
        ISepetUrunService _sepetUrunService;
       public SepetUrunsController(ISepetUrunService sepetUrunService)
        {
            _sepetUrunService = sepetUrunService;
        }
        [HttpPost("add")]
        public IActionResult Add(SepetUrun sepetUrun)
        {
            var result = _sepetUrunService.Add(sepetUrun);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}
