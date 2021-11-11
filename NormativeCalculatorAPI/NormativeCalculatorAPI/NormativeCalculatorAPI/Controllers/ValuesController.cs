using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NormativeCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("signin-google")]
        public async Task Login()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties()
            {
                RedirectUri = Url.Action("GoogleResponse")
            });
        }

        [HttpGet("GoogleResponse")]
        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var claims = result.Principal.Identities.FirstOrDefault().Claims
                .Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });

            //return Json(claims);
            return Ok();


        }

        //[Authorize]
        [HttpGet("signout-google")]

        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                var nesto = User.Identity.Name;
            }
            else
            {
                var nesto = "Home page for guest user.";
            }
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [Authorize]
        [HttpGet("test")]

        public  ActionResult test()
        {
            if (User.Identity.IsAuthenticated)
            {
              var nesto =User.Identity.Name;
            }
            else
            {
                var nesto = "Home page for guest user.";
            }
            return Ok("Login");
        }

    }
}
