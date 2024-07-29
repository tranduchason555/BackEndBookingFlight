using DOANMAYBAY2023.Models;
using DOANMAYBAY2023.Services;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace DOANMAYBAY2023.Controllers
{
    [Route("api/thongtinchuyenbay")]
    public class ThongTinChuyenBayController : Controller
    {

        private ThongTinChuyenBayService thongTinChuyenBayService;
        private SanBayService sanBayService;
        public ThongTinChuyenBayController(ThongTinChuyenBayService _thongTinChuyenBayService, SanBayService sanBayService)
        {
            this.thongTinChuyenBayService = _thongTinChuyenBayService;
            this.sanBayService = sanBayService;
        }
        [Produces("application/json")]
        [HttpDelete("delete/{maCb}")]
        public IActionResult Delete(string maCb)
        {
            try
            {
                return Ok(new
                {
                    status = thongTinChuyenBayService.Delete(maCb)
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
                return Ok(thongTinChuyenBayService.findAll());
            }catch 
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("search/{maSbayDi}/{maSbayDen}/{ngayCatCanh}")]
        public IActionResult search(string maSbayDi, string maSbayDen, string ngayCatCanh)
        {
            var date = DateTime.ParseExact(ngayCatCanh,"dd-MM-yyyy", CultureInfo.InvariantCulture);
            try
            {
                return Ok(thongTinChuyenBayService.search(maSbayDi, maSbayDen, date));
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] ThongTinChuyenBay chuyenbay)
        {
            try
            {
                return Ok(new
                {
                    status = thongTinChuyenBayService.create(chuyenbay)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("find/{maCb}")]
        public IActionResult find(string maCb)
        {
            try
            {
                return Ok(thongTinChuyenBayService.find(maCb));
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("findByDates/{ngayCatCanh}")]
        public IActionResult findByDates(string ngayCatCanh)
        {
            try
            {
                var start = DateTime.ParseExact(ngayCatCanh, "dd-MM-yyyy", CultureInfo.InvariantCulture);
               
                return Ok(thongTinChuyenBayService.findByDates(start));
            }
            catch
            {
                return BadRequest();
            }
        }
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPut("update")]
        //Biến kiểu json thành kiểu đối tượng
        public IActionResult update([FromBody] ThongTinChuyenBay thongtinchuyenbay)
        {
            try
            {
                return Ok(new
                {
                    status = thongTinChuyenBayService.update(thongtinchuyenbay)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("findByDates1/{ngayCatCanh}/{ngayHaCanh}")]
        public IActionResult findByDates1(string ngayCatCanh,string ngayHaCanh)
        {
            try
            {
                var start = DateTime.ParseExact(ngayCatCanh, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var end = DateTime.ParseExact(ngayHaCanh, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                return Ok(thongTinChuyenBayService.findByDates1(start,end));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
