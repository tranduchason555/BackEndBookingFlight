using DOANMAYBAY2023.Models;
using System.ComponentModel;

namespace DOANMAYBAY2023.Services
{
    public class HanhKhachServiceImpl : HanhKhachService
    {
        private DatabaseContext db;
        public HanhKhachServiceImpl(DatabaseContext _db)
        {
            this.db = _db;
        }

        public bool create(HanhKhach hanhkhach)
        {
            try
            {
                db.HanhKhaches.Add(hanhkhach);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic Delete(int maHk)
        {
            try
            {
                db.HanhKhaches.Remove(db.HanhKhaches.Find(maHk));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic find(string taikhoan, string matKhau)
        {
            return db.HanhKhaches.Where(p => p.Taikhoan == taikhoan && p.MatKhau == matKhau).Select(p => new
            {
                MaHk=p.MaHk,
                TenKhachHang=p.TenKhachHang,
                NgaySinh= p.NgaySinh,
                Taikhoan=p.Taikhoan,
                MatKhau=p.MatKhau,
                SoDienThoai=p.SoDienThoai,
                GioiTinh=p.GioiTinh
            }).ToList();
        }

        public dynamic find1(string taikhoan)
        {
            return db.HanhKhaches.Where(p => p.Taikhoan == taikhoan).Select(p => new
            {
                MaHk = p.MaHk,
                TenKhachHang = p.TenKhachHang,
                NgaySinh = p.NgaySinh,
                Taikhoan = p.Taikhoan,
                MatKhau = p.MatKhau,
                SoDienThoai = p.SoDienThoai,
                GioiTinh = p.GioiTinh
            }).ToList();
        }

        public dynamic find2(string tenHanhKhach)
        {
            return db.HanhKhaches.Where(p => p.TenKhachHang.Contains(tenHanhKhach)).Select(p => new
            {
                MaHk = p.MaHk,
                TenKhachHang = p.TenKhachHang,
                NgaySinh = p.NgaySinh,
                Taikhoan = p.Taikhoan,
                MatKhau = p.MatKhau,
                SoDienThoai = p.SoDienThoai,
                GioiTinh = p.GioiTinh
            }).ToList();
        }

        public dynamic findAll()
        {
            return db.HanhKhaches.Select(p => new
            {
                MaHk = p.MaHk,
                TenKhachHang = p.TenKhachHang,
                NgaySinh = p.NgaySinh,
                Taikhoan = p.Taikhoan,
                MatKhau = p.MatKhau,
                SoDienThoai = p.SoDienThoai,
                GioiTinh = p.GioiTinh
            }).ToList();
        }

        public bool login(string taiKhoan, string matKhau)
        {
            return db.HanhKhaches.Count(a=>a.Taikhoan== taiKhoan &&  a.MatKhau==matKhau)>0;
        }

        public bool update(HanhKhach hanhkhach)
        {
            try
            {
                db.Entry(hanhkhach).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
