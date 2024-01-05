using System;
using System.Collections.Generic;

namespace TiraciptaAPI.Models;

public partial class Price
{
    public string? ProductCode { get; set; }

    public decimal? Price1 { get; set; }

    public DateTime? PriceValidateFrom { get; set; }

    public DateTime? PriceValidateTo { get; set; }
}
