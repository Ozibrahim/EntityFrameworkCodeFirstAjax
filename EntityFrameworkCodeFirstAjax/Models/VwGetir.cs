using System;
using System.Collections.Generic;

namespace EntityFrameworkCodeFirstAjax.Models;

public partial class VwGetir
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadı { get; set; } = null!;

    public string Katergoriadi { get; set; } = null!;

    public int? SatışSayısı { get; set; }
}
