using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marcusca10.AadAppsDemos.WebApi.AspNetCore.Models
{
    public class AboutViewModel
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public string Issuer { get; set; }
        public string OriginalIssuer { get; set; }
    }
}
