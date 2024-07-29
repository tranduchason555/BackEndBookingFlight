using DOANMAYBAY2023.Models;
using DOANMAYBAY2023.Services;
using Microsoft.AspNetCore.Mvc;

namespace DOANMAYBAY2023.Controllers
{
    [Route("api/adminuser")]
    public class AdminUserController : Controller
    {
        private AdminUserService adminUserService;
        public AdminUserController(AdminUserService _adminUserService)
        {
            this.adminUserService = _adminUserService;
        }
        [Produces("application/json")]
        [HttpDelete("delete/{maHk}")]
        public IActionResult Delete(int maHk)
        {
            try
            {
                return Ok(new
                {
                    status = adminUserService.Delete(maHk)
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
        public IActionResult Create([FromBody] AdminUser adminuser)
        {
            try
            {
                return Ok(new
                {
                    status = adminUserService.create(adminuser)
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
                return Ok(adminUserService.findAll());

            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("find/{taiKhoan}/{matKhau}")]
        public IActionResult find(string taiKhoan, string matKhau)
        {
            try
            {
                return Ok(adminUserService.find(taiKhoan, matKhau));
            }
            catch
            {
                return BadRequest();
            }

        }
            [Produces("application/json")]
        [Route("login/{taiKhoan}/{matKhau}")]
        public IActionResult login(string taiKhoan, string matKhau)
        {
            try
            {
                return Ok(adminUserService.login(taiKhoan, matKhau));
            }
            catch
            {
                return BadRequest();
            }


        }
    }
}
