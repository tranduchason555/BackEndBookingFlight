using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public class VeServiceImpl : VeService
    {
        private DatabaseContext db;
        private IConfiguration configuration;
        private ThongTinChuyenBayService thongtinchuyenbay;
        public VeServiceImpl(DatabaseContext _db, IConfiguration _configuration, ThongTinChuyenBayService _thongtinchuyenbay)
        {
            db = _db;
            configuration = _configuration;
            this.thongtinchuyenbay = _thongtinchuyenbay;
        }
        public bool create(Ve ve)
        {
            try
            {
                ve.ThoiGianDat=DateTime.Now;
                db.Ves.Add(ve);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic Delete(int maVe)
        {
            try
            {

                db.Ves.Remove(db.Ves.Find(maVe));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic find(string maCb)
        {
            return db.Ves.Where(p => p.MaCb == maCb ).Select(p => new
            {
                MaVe=p.MaVe,
                ThoiGianDat=p.ThoiGianDat,
                ThoiGianDi=p.ThoiGianDi,
                LoaiGhe=p.LoaiGhe,
                GiaGhe=p.GiaGhe,
                MaHk = p.MaHk,
                SoLuong = p.SoLuong,
                MaCb =p.MaCb,
            }).ToList();
        }

        public dynamic find1(int maHk)
        {
            return db.Ves.Where(p => p.MaHk == maHk).Select(p => new
            {
                MaVe = p.MaVe,
                ThoiGianDat = p.ThoiGianDat,
                ThoiGianDi = p.ThoiGianDi,
                LoaiGhe = p.LoaiGhe,
                GiaGhe = p.GiaGhe,
                MaHk = p.MaHk,
                SoLuong = p.SoLuong,
                MaCb = p.MaCb,
            }).ToList();
        }

        public dynamic findAll()
        {
            return db.Ves.Select(p => new
            {
                MaVe = p.MaVe,
                ThoiGianDat = p.ThoiGianDat,
                ThoiGianDi = p.ThoiGianDi,
                LoaiGhe = p.LoaiGhe,
                GiaGhe = p.GiaGhe,
                SoLuong = p.SoLuong,
                MaHk = p.MaHk,
                MaCb = p.MaCb,
            }).ToList();
        }

        public dynamic findByDates(DateTime thoiGianDi)
        {
            return db.Ves.Where(p => p.ThoiGianDi == thoiGianDi).Select(p => new
            {
                MaVe = p.MaVe,
                ThoiGianDat = p.ThoiGianDat,
                ThoiGianDi = p.ThoiGianDi,
                LoaiGhe = p.LoaiGhe,
                GiaGhe = p.GiaGhe,
                SoLuong = p.SoLuong,
                MaHk = p.MaHk,
                MaCb = p.MaCb,
            }).ToList();
        }

        public dynamic findByDates1(DateTime thoiGianDat, DateTime thoiGianDi)
        {
            return db.Ves.Where(p => p.ThoiGianDi == thoiGianDi && p.ThoiGianDat == thoiGianDat).Select(p => new
            {
                MaVe = p.MaVe,
                ThoiGianDat = p.ThoiGianDat,
                ThoiGianDi = p.ThoiGianDi,
                LoaiGhe = p.LoaiGhe,
                GiaGhe = p.GiaGhe,
                SoLuong = p.SoLuong,
                MaHk = p.MaHk,
                MaCb = p.MaCb,
            }).ToList();
        }
    }
}
