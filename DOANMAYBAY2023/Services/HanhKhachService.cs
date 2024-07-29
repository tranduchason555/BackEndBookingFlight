using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public interface HanhKhachService
    {
        public dynamic findAll();
        public bool login(string taiKhoan, string matKhau);
        public dynamic find(string taikhoan, string matKhau);
        public dynamic find1(string taikhoan);
        public bool create(HanhKhach hanhkhach);
        public dynamic Delete(int maHk);
        public bool update(HanhKhach hanhkhach);
        public dynamic find2(string tenHanhKhach);
    }
}
