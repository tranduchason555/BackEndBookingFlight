using DOANMAYBAY2023.Models;
using DOANMAYBAY2023.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using System.Globalization;

namespace DOANMAYBAY2023.Controllers
{

    [Route("api/ve")]
    public class VeController : Controller
    {

        private VeService veService;
        private IWebHostEnvironment webHostEnvironment;
        private ThongTinChuyenBayService thongTinChuyenBayService;
        public VeController(VeService _veService, IWebHostEnvironment _webHostEnvironment, ThongTinChuyenBayService _thongTinChuyenBayService)
        {
            veService = _veService;
            webHostEnvironment = _webHostEnvironment;
            thongTinChuyenBayService = _thongTinChuyenBayService;
        }
        [Produces("application/json")]
        [HttpGet("findAll")]
        public IActionResult findAll()
        {
            try
            {
                return Ok(veService.findAll());

            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] Ve ve)
        {
            try
            {
               
                    return Ok(new
                    {

                        status = veService.create(ve)
                    });


                
                   
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(new
                {
                    status = veService.Delete(id)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("find1/{maHk}")]
        public IActionResult find1(int maHk)
        {
            try
            {
                return Ok(veService.find1(maHk));
            }
            catch
            {
                return BadRequest();
            }


        }
        [Produces("application/json")]
        [Route("findByDates/{thoiGianDi}")]
        public IActionResult findByDates(string thoiGianDi)
        {
            try
            {
                var start = DateTime.ParseExact(thoiGianDi, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                return Ok(veService.findByDates(start));
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("findByDates1/{thoiGianDat}/{thoiGianDi}")]
        public IActionResult findByDates1(string thoiGianDat, string thoiGianDi)
        {
            try
            {
                var start = DateTime.ParseExact(thoiGianDat, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var end = DateTime.ParseExact(thoiGianDi, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                return Ok(veService.findByDates1(start, end));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
