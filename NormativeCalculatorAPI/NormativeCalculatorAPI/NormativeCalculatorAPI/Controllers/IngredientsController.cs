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
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsService _ingredientsService;
        public IngredientsController(IIngredientsService ingredients)
        {
            _ingredientsService = ingredients;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetIngredientsAsync(CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _ingredientsService.GetIngredientsAsync(cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> InsertRecipeAsync(IngredientAddRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _ingredientsService.InsertIngredientAsync(request, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
