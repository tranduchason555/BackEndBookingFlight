using DOANMAYBAY2023.Models;
using DOANMAYBAY2023.Services;
using Microsoft.AspNetCore.Mvc;

namespace DOANMAYBAY2023.Controllers
{
    [Route("api/hanhkhach")]
    public class HanhKhachController : Controller
    {
        private HanhKhachService hanhKhachService;
        public HanhKhachController(HanhKhachService _hanhKhachService) {
            this.hanhKhachService = _hanhKhachService;
        }
        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] HanhKhach hanhkhach)
        {
            try
            {
                return Ok(new
                {
                    status = hanhKhachService.create(hanhkhach)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("findAll")]
        public IActionResult findAll()
        {
            try
            {
                return Ok(hanhKhachService.findAll());

            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("find/{taikhoan}/{matKhau}")]
        public IActionResult find(string taikhoan, string matKhau)
        {
            try
            {
                return Ok(hanhKhachService.find(taikhoan, matKhau));
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
        public IActionResult update([FromBody] HanhKhach hanhkhach)
        {
            try
            {
                return Ok(new
                {
                    status = hanhKhachService.update(hanhkhach)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Route("find1/{taikhoan}")]
        public IActionResult find1(string taikhoan)
        {
            try
            {
                return Ok(hanhKhachService.find1(taikhoan));
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
                    status = hanhKhachService.Delete(id)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("find2/{tenHanhKhach}")]
        public IActionResult find2(string tenHanhKhach)
        {
            try
            {
                return Ok(hanhKhachService.find2(tenHanhKhach));
            }
            catch
            {
                return BadRequest();
            }


        }
    }
}
