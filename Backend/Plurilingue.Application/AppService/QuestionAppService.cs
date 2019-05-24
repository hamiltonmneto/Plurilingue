using Plurilingue.Application.Interfaces;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Interfaces.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.AppService
{
    public class QuestionAppService : IQuestionAppService
    {
        public readonly IQuestionService _questionService;
        public QuestionAppService(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        public long AddNewQuestion(TopicInputModel model)
        {
            return _questionService.AddNewQuestion(null);
        }
    }
}
