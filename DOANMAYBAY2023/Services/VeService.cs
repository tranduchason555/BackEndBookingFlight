using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public interface VeService
    {
        public dynamic find(string maCb);
        public bool create(Ve ve);
        public dynamic findAll();
        public dynamic find1(int maHk);
        public dynamic Delete(int maVe);
        public dynamic findByDates(DateTime thoiGianDi);
        public dynamic findByDates1(DateTime thoiGianDat, DateTime thoiGianDi);
    }
}
