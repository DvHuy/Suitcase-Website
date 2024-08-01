using System;
using System.Collections.Generic;

namespace Suitcase_Website.Models;

public partial class TAnhSp
{
    public string MaSp { get; set; } = null!;

    public string TenFileAnh { get; set; } = null!;

    public short? ViTri { get; set; }

    public virtual TDanhMucSp MaSpNavigation { get; set; } = null!;
}
