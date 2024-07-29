using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public interface ThongTinChuyenBayService
    {
        public dynamic findAll();
        public dynamic find(string maCb);
        public dynamic search(string maSbayDi, string maSbayDen, DateTime ngayCatCanh);
        public dynamic search11(string masbaydi, string masbayden);
        public ThongTinChuyenBay find1(string maCb);
        public ThongTinChuyenBay find2(string maCb);
        public bool create(ThongTinChuyenBay sanbay);
        public dynamic Delete(string maCb);
        public dynamic findByDates(DateTime ngayCatCanh);
        public dynamic findByDates1(DateTime ngayCatCanh,DateTime ngayHaCanh);
        public bool update(ThongTinChuyenBay thongtinchuyenbay);
    }
}
