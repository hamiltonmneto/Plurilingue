using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plurilingue.Application.Interfaces;
using Plurilingue.Application.ViewModels;
using Plurilingue.Infra.CrossCutting.Exceptions;

namespace Plurilingue.Application.Controllers
{
    [Route("v1/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly IUserAppService _userAppService;
        public AuthController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterInputModel model)
        {
            try
            {
                return Ok(_userAppService.AddNewUser(model));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginInput model)
        {
            try
            {
                return Ok(_userAppService.Authentication(model));
            }
            catch(PlurilingueException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult("Internal Error, please report to us.");
            }
        }
    }
}