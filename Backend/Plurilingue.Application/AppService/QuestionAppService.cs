using AutoMapper;
using Plurilingue.Application.Interfaces;
using Plurilingue.Application.OutputModels;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;
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
        private readonly IMapper _mapper;
        public QuestionAppService(IQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }
        public void AddNewQuestion(TopicInputModel model)
        {
            _questionService.AddNewQuestion(_mapper.Map<TopicInputModel,Question>(model));
        }

        public QuestionsOutPutModel GetQuestion(long id) 
            => _mapper.Map<QuestionsOutPutModel>(_questionService.GetQuestion(id));

        public List<QuestionsOutPutModel> GetQuestions() 
            => _mapper.Map<List<QuestionsOutPutModel>>(_questionService.GetQuestion());

    }
}
