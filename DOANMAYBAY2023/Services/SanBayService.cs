using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public interface SanBayService
    {
        public dynamic findAll();
        public dynamic find(string maSbaydi,string maSbayden);
        public bool create(SanBay sanbay);
        public dynamic Delete(string maSbay);
        public dynamic find2(string tenTinhThanh);
    }
}
