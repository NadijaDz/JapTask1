using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly IRecipesService _recipesService;
        private readonly UserManager<IdentityUser> _userManager;

        public RecipesController(IRecipesService recipes, UserManager<IdentityUser> userManager)
        {
            _recipesService = recipes;
            _userManager = userManager;
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipesByIdAsync(int id, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _recipesService.GetRecipesByIdAsync(id, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetRecipesAsync([FromQuery] IncomingParamsModel request, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _recipesService.GetRecipesAsync(request, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> InsertRecipeAsync(RecipesAddRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                request.User = user;
                request.UserId = user.Id;

                return Ok(await _recipesService.InsertRecipeAsync(request, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
