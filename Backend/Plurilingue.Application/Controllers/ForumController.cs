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
        public async Task<IActionResult> AddTopic(TopicInputModel model)
        {
            try
            {
                return Ok(_questionAppService.AddNewQuestion(model));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public async Task<IActionResult> UpdateTopic(TopicInputModel model)
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

        public async Task<IActionResult> GetTopics()
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
    }
}