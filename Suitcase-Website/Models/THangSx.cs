using System;
using System.Collections.Generic;

namespace Suitcase_Website.Models;

public partial class THangSx
{
    public string MaHangSx { get; set; } = null!;

    public string? HangSx { get; set; }

    public string? MaNuocThuongHieu { get; set; }

    public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; } = new List<TDanhMucSp>();
}
