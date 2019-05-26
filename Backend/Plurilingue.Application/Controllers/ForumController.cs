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
    [Route("v1/forum")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        public readonly IQuestionAppService _questionAppService;

        public ForumController(IQuestionAppService questionAppService)
        {
            _questionAppService = questionAppService;
        }
        [Route("AddQuestion")]
        [HttpPost]
        public async Task<IActionResult> AddQuestion(TopicInputModel model)
        {
            try
            {
                _questionAppService.AddNewQuestion(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public async Task<IActionResult> UpdateQuestion(TopicInputModel model)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [Route("GetQuestions")]
        [HttpGet]
        public async Task<IActionResult> GetQuestions()
        {
            try
            {
                return Ok(_questionAppService.GetQuestions());
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}