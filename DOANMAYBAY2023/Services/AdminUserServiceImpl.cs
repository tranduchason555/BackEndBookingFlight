using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public class AdminUserServiceImpl : AdminUserService
    {
        private DatabaseContext db;
        public AdminUserServiceImpl(DatabaseContext _db) {  this.db = _db; }

        public bool create(AdminUser adminuser)
        {
            try
            {
                db.AdminUsers.Add(adminuser);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic Delete(int id)
        {
            try
            {
                db.AdminUsers.Remove(db.AdminUsers.Find(id));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic find(string taiKhoan, string matKhau)
        {
            return db.AdminUsers.Where(p => p.TaiKhoan == taiKhoan && p.MatKhau == matKhau).Select(p => new
            {
                Id = p.Id,
                TaiKhoan = p.TaiKhoan,
                MatKhau = p.MatKhau
            }).ToList();
        }

        public dynamic findAll()
        {
            return db.AdminUsers.Select(p => new
            {
                Id=p.Id,
                TaiKhoan=p.TaiKhoan,
                MatKhau=p.MatKhau
            }).ToList();
        }

        public bool login(string taiKhoan, string matKhau)
        {
            return db.AdminUsers.Count(a => a.TaiKhoan == taiKhoan && a.MatKhau == matKhau) > 0;
        }
    }
}
