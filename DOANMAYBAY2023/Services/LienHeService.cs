using DOANMAYBAY2023.Models;

namespace DOANMAYBAY2023.Services
{
    public interface LienHeService
    {
        public bool create(FormLienHe lienhe);
        public dynamic findAll();
        public dynamic Delete(int maForm);
    }
}
