using System;
using System.Collections.Generic;

namespace DOANMAYBAY2023.Models;

public partial class SanBay
{
    public string MaSbay { get; set; } = null!;

    public string? TenSbay { get; set; }

    public string? TenTinhThanh { get; set; }

    public virtual ICollection<ThongTinChuyenBay> ThongTinChuyenBayMaSbayDenNavigations { get; set; } = new List<ThongTinChuyenBay>();

    public virtual ICollection<ThongTinChuyenBay> ThongTinChuyenBayMaSbayDiNavigations { get; set; } = new List<ThongTinChuyenBay>();
}
