
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeCategoriesController : ControllerBase
    {
        private readonly IRecipeCategoriesService _recipeCategories;
        public RecipeCategoriesController(IRecipeCategoriesService recipeCategories)
        {
            _recipeCategories = recipeCategories;
        }

        [Authorize]
        //[Route("GetRecipeCategories")]
        [HttpGet]
        public async Task<IActionResult> GetRecipeCategoriesAsync([FromQuery] int skip, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _recipeCategories.GetRecipeCategoriesAsync(skip, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
