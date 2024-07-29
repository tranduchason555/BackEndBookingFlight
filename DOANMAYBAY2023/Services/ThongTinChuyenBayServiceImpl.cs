using DOANMAYBAY2023.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DOANMAYBAY2023.Services
{
    public class ThongTinChuyenBayServiceImpl : ThongTinChuyenBayService
    {
        private DatabaseContext db;
        private IConfiguration configuration;
        public ThongTinChuyenBayServiceImpl(DatabaseContext _db, IConfiguration _configuration )
        {
            this.db = _db;
            this.configuration = _configuration;
           
        }

        public bool create(ThongTinChuyenBay chuyenbay)
        {
            try
            {
                db.ThongTinChuyenBays.Add(chuyenbay);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic Delete(string maCb)
        {
            try
            {
                var recordsToDelete = db.ThongTinChuyenBays.Where(p => p.MaCb == maCb).ToList();

                if (recordsToDelete.Count > 0)
                {
                    db.ThongTinChuyenBays.RemoveRange(recordsToDelete);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    // Return false if no records matched the condition.
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception.
                return false;
            }
        }

        public dynamic find(string maCb)
        {
            return db.ThongTinChuyenBays.Where(p=>p.MaCb== maCb).Select(p => new
            {
                MaCb = p.MaCb,
                TenCb = p.TenCb,
                NgayCatCanh = p.NgayCatCanh,
                GioCatCanh = p.GioCatCanh,
                NgayHaCanh = p.NgayHaCanh,
                GioHaCanh = p.GioHaCanh,
                MaSbayDi = p.MaSbayDiNavigation.MaSbay,
                MaSbayDen = p.MaSbayDenNavigation.MaSbay,
                TenTinhThanhSanBayDi = p.MaSbayDiNavigation.TenTinhThanh,
                TenTinhThanhSanBayDen = p.MaSbayDenNavigation.TenTinhThanh,
                GheLoai1 = p.GheLoai1,
                GheLoai2 = p.GheLoai2,
                SoLuongVe= p.SoLuongVe,
                GiaGheLoai1 = p.GiaGheLoai1,
                GiaGheLoai2 = p.GiaGheLoai2,
            }).ToList();
        }

        public ThongTinChuyenBay find1(string maCb)
        {
            return db.ThongTinChuyenBays.AsNoTracking().SingleOrDefault(p => p.MaCb == maCb);
        }

        public ThongTinChuyenBay find2(string maCb)
        {
            return db.ThongTinChuyenBays.AsNoTracking().SingleOrDefault(p => p.MaCb == maCb);
        }

        public dynamic findAll()
        {
            return db.ThongTinChuyenBays.Select(p => new
            {
                MaCb = p.MaCb,
                TenCb = p.TenCb,
                NgayCatCanh = p.NgayCatCanh,
                GioCatCanh = p.GioCatCanh,
                NgayHaCanh = p.NgayHaCanh,
                GioHaCanh = p.GioHaCanh,
                MaSbayDi = p.MaSbayDiNavigation.MaSbay,
                MaSbayDen = p.MaSbayDenNavigation.MaSbay,
                TenTinhThanhSanBayDi = p.MaSbayDiNavigation.TenTinhThanh,
                TenTinhThanhSanBayDen = p.MaSbayDenNavigation.TenTinhThanh,
            
                GheLoai1 = p.GheLoai1,
                GheLoai2 = p.GheLoai2,
                SoLuongVe = p.SoLuongVe,
                GiaGheLoai1 = p.GiaGheLoai1,
                GiaGheLoai2 = p.GiaGheLoai2,
            }).ToList();
        }

        public dynamic findByDates(DateTime ngayCatCanh)
        {
            return db.ThongTinChuyenBays.Where(p => p.NgayCatCanh == ngayCatCanh).Select(p => new
            {
                MaCb = p.MaCb,
                TenCb = p.TenCb,
                NgayCatCanh = p.NgayCatCanh,
                GioCatCanh = p.GioCatCanh,
                NgayHaCanh = p.NgayHaCanh,
                GioHaCanh = p.GioHaCanh,
                MaSbayDi = p.MaSbayDiNavigation.MaSbay,
                MaSbayDen = p.MaSbayDenNavigation.MaSbay,
                TenTinhThanhSanBayDi = p.MaSbayDiNavigation.TenTinhThanh,
                TenTinhThanhSanBayDen = p.MaSbayDenNavigation.TenTinhThanh,

                GheLoai1 = p.GheLoai1,
                GheLoai2 = p.GheLoai2,
                SoLuongVe = p.SoLuongVe,
                GiaGheLoai1 = p.GiaGheLoai1,
                GiaGheLoai2 = p.GiaGheLoai2,
            }).ToList();
        }

        public dynamic findByDates1(DateTime ngayCatCanh, DateTime ngayHaCanh)
        {
            return db.ThongTinChuyenBays.Where(p => p.NgayCatCanh == ngayCatCanh && p.NgayHaCanh==ngayHaCanh).Select(p => new
            {
                MaCb = p.MaCb,
                TenCb = p.TenCb,
                NgayCatCanh = p.NgayCatCanh,
                GioCatCanh = p.GioCatCanh,
                NgayHaCanh = p.NgayHaCanh,
                GioHaCanh = p.GioHaCanh,
                MaSbayDi = p.MaSbayDiNavigation.MaSbay,
                MaSbayDen = p.MaSbayDenNavigation.MaSbay,
                TenTinhThanhSanBayDi = p.MaSbayDiNavigation.TenTinhThanh,
                TenTinhThanhSanBayDen = p.MaSbayDenNavigation.TenTinhThanh,

                GheLoai1 = p.GheLoai1,
                GheLoai2 = p.GheLoai2,
                SoLuongVe = p.SoLuongVe,
                GiaGheLoai1 = p.GiaGheLoai1,
                GiaGheLoai2 = p.GiaGheLoai2,
            }).ToList();
        }

        public dynamic search(string maSbayDi, string maSbayDen , DateTime ngayCatCanh)
        {
            return db.ThongTinChuyenBays.Where(p => p.MaSbayDi == maSbayDi && p.MaSbayDen == maSbayDen && p.NgayCatCanh == ngayCatCanh).Select(p => new
            {
                MaCb = p.MaCb,
                TenCb = p.TenCb,
                NgayCatCanh = p.NgayCatCanh,
                GioCatCanh = p.GioCatCanh,
                NgayHaCanh = p.NgayHaCanh,
                GioHaCanh = p.GioHaCanh,
                MaSbayDi = p.MaSbayDiNavigation.MaSbay,
                MaSbayDen = p.MaSbayDenNavigation.MaSbay,
                TenTinhThanhSanBayDi = p.MaSbayDiNavigation.TenTinhThanh,
                TenTinhThanhSanBayDen = p.MaSbayDenNavigation.TenTinhThanh,
             
                GheLoai1 = p.GheLoai1,
                GheLoai2 = p.GheLoai2,
                SoLuongVe = p.SoLuongVe,
                GiaGheLoai1 = p.GiaGheLoai1,
                GiaGheLoai2 = p.GiaGheLoai2,
            }).ToList();
        }

        public dynamic search11(string masbaydi, string masbayden)
        {
            throw new NotImplementedException();
        }

        public bool update(ThongTinChuyenBay thongtinchuyenbay)
        {
            try
            {
                db.Entry(thongtinchuyenbay).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        /*  MaSbayDi=p.MaSbayDiNavigation.MaSbay,
                    MaSbayDen= p.MaSbayDenNavigation.MaSbay*/
    }
}