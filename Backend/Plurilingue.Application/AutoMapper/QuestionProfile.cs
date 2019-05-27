using AutoMapper;
using Plurilingue.Application.OutputModels;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurilingue.Application.AutoMapper
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<TopicInputModel,Question>();
            CreateMap<AnswerOutputModel, Answer>();
            CreateMap<QuestionsOutPutModel, Question>();
        }
    }
}
