using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public class LienHeServiceImpl : LienHeService
    {
        private DatabaseContext db;
        private IConfiguration configuration;

        public LienHeServiceImpl(DatabaseContext _db, IConfiguration _configuration)
        {
            db = _db;
            configuration = _configuration;
        }
        public bool create(FormLienHe lienhe)
        {
            try
            {
                db.FormLienHes.Add(lienhe);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic Delete(int maForm)
        {
            try
            {
                db.FormLienHes.Remove(db.FormLienHes.Find(maForm));
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public dynamic findAll()
        {
            return db.FormLienHes.Select(p => new
            {
                MaForm=p.MaForm,
                HoTen = p.HoTen,
                Gmail = p.Gmail,
                TieuDe = p.TieuDe,
                VanDe = p.VanDe,
            }).ToList();
        }
    }
}
