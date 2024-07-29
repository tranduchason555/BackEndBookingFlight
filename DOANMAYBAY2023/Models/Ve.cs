using System;
using System.Collections.Generic;

namespace DOANMAYBAY2023.Models;

public partial class Ve
{
    public int MaVe { get; set; }

    public DateTime? ThoiGianDat { get; set; }

    public DateTime? ThoiGianDi { get; set; }

    public string? LoaiGhe { get; set; }

    public int? GiaGhe { get; set; }

    public int? SoLuong { get; set; }

    public string? MaCb { get; set; }

    public int? MaHk { get; set; }

    public virtual ThongTinChuyenBay? MaCbNavigation { get; set; }

    public virtual HanhKhach? MaHkNavigation { get; set; }
}
