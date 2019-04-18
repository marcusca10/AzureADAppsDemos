using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marcusca10.AadAppsDemos.WebApi.AspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marcusca10.AadAppsDemos.WebApi.AspNetCore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AboutController : Controller
    {
        // GET api/me
        [HttpGet]
        public IActionResult Index()
        {
            if (User.Claims != null)
            {
                var result = new List<AboutViewModel>();
                foreach (var claim in User.Claims)
                {
                    result.Add(new AboutViewModel
                        {
                            Type = claim.Type,
                            Value = claim.Value,
                            Issuer = claim.Issuer,
                            OriginalIssuer = claim.OriginalIssuer
                        });
                }

                return Json(result);
            }
            else
                return ValidationProblem();
        }
    }
}