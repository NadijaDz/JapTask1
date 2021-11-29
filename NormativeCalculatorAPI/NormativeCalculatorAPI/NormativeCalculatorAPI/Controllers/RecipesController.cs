using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Core.Models.Request;
using NormativeCalculator.Services;
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
        private readonly IRecipeService _recipesService;
        private readonly UserManager<IdentityUser> _userManager;

        public RecipesController(IRecipeService recipes, UserManager<IdentityUser> userManager)
        {
            _recipesService = recipes;
            _userManager = userManager;
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipesByIdAsync(int id, CancellationToken cancellationToken)
        {
            return Ok(await _recipesService.GetRecipeByIdAsync(id, cancellationToken));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetRecipesAsync([FromQuery] RecipeSearchRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _recipesService.GetRecipesAsync(request, cancellationToken));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> InsertRecipeAsync(AddRecipeRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _recipesService.InsertRecipeAsync(request, cancellationToken));
        }
    }
}
