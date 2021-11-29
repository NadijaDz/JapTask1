using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Core.Models.Request;
using NormativeCalculator.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NormativeCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientsService;
        public IngredientsController(IIngredientService ingredients)
        {
            _ingredientsService = ingredients;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetIngredientsAsync(CancellationToken cancellationToken)
        {
            return Ok(await _ingredientsService.GetIngredientsAsync(cancellationToken));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> InsertRecipeAsync(AddIngredientRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _ingredientsService.InsertIngredientAsync(request, cancellationToken));
        }

    }
}
