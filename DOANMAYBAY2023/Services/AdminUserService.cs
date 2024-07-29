using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public interface AdminUserService
    {
        public dynamic findAll();
        public bool create(AdminUser adminuser);
        public dynamic Delete(int id);
        public bool login(string taiKhoan, string matKhau);
        public dynamic find(string taiKhoan, string matKhau);

    }
}
