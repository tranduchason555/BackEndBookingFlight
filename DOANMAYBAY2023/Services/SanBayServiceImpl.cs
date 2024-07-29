using DOANMAYBAY2023.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DOANMAYBAY2023.Services
{
    public class SanBayServiceImpl : SanBayService
    {
        private DatabaseContext db;
        private IConfiguration configuration;
        public SanBayServiceImpl(DatabaseContext _db, IConfiguration _configuration)
        {
            this.db = _db;
            this.configuration = _configuration;
        }

        public bool create(SanBay sanbay)
        {
            try
            {
                db.SanBays.Add(sanbay);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic Delete(string maSbay)
        {
            try
            {
                db.SanBays.Remove(db.SanBays.Find(maSbay));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic find(string maSbaydi, string maSbayden)
        {
            return db.SanBays.Where(p => p.MaSbay == maSbaydi && p.MaSbay == maSbayden).Select(p => new
            {
                MaSbay = p.MaSbay,
                TenSbay = p.TenSbay,
                TenTinhThanh = p.TenTinhThanh
            }).ToList();
        }

        public dynamic find2(string tenTinhThanh)
        {
            return db.SanBays.Where(p => p.TenTinhThanh.Contains(tenTinhThanh)).Select(p => new
            {
                MaSbay = p.MaSbay,
                TenSbay = p.TenSbay,
                TenTinhThanh = p.TenTinhThanh
            }).ToList();
        }

        public dynamic findAll()
        {
            return db.SanBays.Select(p => new
            {
                MaSbay=p.MaSbay,
                TenSbay=p.TenSbay,
                TenTinhThanh=p.TenTinhThanh,
            }).ToList();
        }
    }
}
