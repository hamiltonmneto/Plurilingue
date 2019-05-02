using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plurilingue.Application.Interfaces;
using Plurilingue.Application.ViewModels;

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
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterInputModel model)
        {
            try
            {

                return Ok(_userAppService.AddNewUser(model));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}