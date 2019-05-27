using System;
using System.Threading.Tasks;
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
        public readonly IAnswerAppService _answerAppService;

        public ForumController(IQuestionAppService questionAppService, IAnswerAppService answerAppService)
        {
            _questionAppService = questionAppService;
            _answerAppService = answerAppService;
        }
        [Route("AddQuestion")]
        [HttpPost]
        public ActionResult AddQuestion(TopicInputModel model)
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
        public ActionResult GetQuestions()
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
        [Route("{id}")]
        [HttpGet]
        public ActionResult GetQuestion(long id)
        {
            try
            {
                var question = _questionAppService.GetQuestion(id);
                return Ok(question);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [Route("RegisterAnswer")]
        [HttpPost]
        public ActionResult RegisterAnswer(AnswerInputModel model)
        {
            try
            {
                _answerAppService.RegisterAnswer(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [Route("BestAnswer/{id}")]
        [HttpPost]
        public ActionResult BestAnswer(long id)
        {
            try
            {
                _answerAppService.RegisterBestAnswer(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}