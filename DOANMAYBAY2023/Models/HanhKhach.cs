using System;
using System.Collections.Generic;

namespace DOANMAYBAY2023.Models;

public partial class HanhKhach
{
    public int MaHk { get; set; }

    public string? TenKhachHang { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Taikhoan { get; set; }

    public string? MatKhau { get; set; }

    public string? GioiTinh { get; set; }

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
