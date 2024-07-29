using DOANMAYBAY2023.Models;
using DOANMAYBAY2023.Services;
using Microsoft.AspNetCore.Mvc;

namespace DOANMAYBAY2023.Controllers
{
    [Route("api/feedback")]
    public class LienHeController : Controller
    {
        private LienHeService lienHeService;
        private IWebHostEnvironment webHostEnvironment;
        public LienHeController(LienHeService _lienHeService, IWebHostEnvironment _webHostEnvironment)
        {
            lienHeService = _lienHeService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Produces("application/json")]
        [HttpGet("findAll")]
        public IActionResult findAll()
        {
            try
            {
                return Ok(lienHeService.findAll());

            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpDelete("delete/{maForm}")]
        public IActionResult Delete(int maForm)
        {
            try
            {
                return Ok(new
                {
                    status = lienHeService.Delete(maForm)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] FormLienHe feedback)
        {
            try
            {
                return Ok(new
                {
                    status = lienHeService.create(feedback)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
