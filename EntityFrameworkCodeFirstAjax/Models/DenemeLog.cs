using System;
using System.Collections.Generic;

namespace EntityFrameworkCodeFirstAjax.Models;

public partial class DenemeLog
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Aciklama { get; set; }
}
