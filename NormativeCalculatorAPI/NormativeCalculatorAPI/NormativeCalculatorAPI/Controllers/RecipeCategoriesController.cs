using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeCategoriesController : ControllerBase
    {
        private readonly IRecipeCategoryService _recipeCategoriesService;
        public RecipeCategoriesController(IRecipeCategoryService recipeCategories)
        {
            _recipeCategoriesService = recipeCategories;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetRecipeCategoriesAsync([FromQuery] int skip, CancellationToken cancellationToken)
        {
            return Ok(await _recipeCategoriesService.GetRecipeCategoriesAsync(skip, cancellationToken));
        }
    }
}
