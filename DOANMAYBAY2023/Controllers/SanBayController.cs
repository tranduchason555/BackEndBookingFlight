using DOANMAYBAY2023.Models;
using DOANMAYBAY2023.Services;
using Microsoft.AspNetCore.Mvc;

namespace DOANMAYBAY2023.Controllers
{
    [Route("api/sanbay")]
    public class SanBayController : Controller
    {
        private SanBayService sanBayService;
        public SanBayController(SanBayService _sanBayService)
        {
            this.sanBayService = _sanBayService;
        }
        [Produces("application/json")]
        [HttpDelete("delete/{maSbay}")]
        public IActionResult Delete(string maSbay)
        {
            try
            {
                return Ok(new
                {
                    status = sanBayService.Delete(maSbay)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpGet("findAll")]
        public IActionResult findAll()
        {
            try
            {
                return Ok(sanBayService.findAll());

            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] SanBay sanbay)
        {
            try
            {
                return Ok(new
                {
                    status = sanBayService.create(sanbay)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("find/{maSbaydi}/{maSbayden}")]
        public IActionResult find(string maSbaydi, string maSbayden)
        {
            try
            {
                return Ok(sanBayService.find(maSbaydi,maSbayden));
            }
            catch
            {
                return BadRequest();
            }


        }
        [Produces("application/json")]
        [Route("find2/{tenTinhThanh}")]
        public IActionResult find2(string tenTinhThanh)
        {
            try
            {
                return Ok(sanBayService.find2(tenTinhThanh));
            }
            catch
            {
                return BadRequest();
            }


        }
    }
}
