using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.DTOs;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipesService _recipes;
        public RecipesController(IRecipesService recipes)
        {
            _recipes = recipes;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetRecipesAsync([FromQuery] IncomingParamsModel request, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _recipes.GetRecipesAsync(request, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
