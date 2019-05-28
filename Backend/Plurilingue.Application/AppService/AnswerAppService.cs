using AutoMapper;
using Plurilingue.Application.Interfaces;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;
using Plurilingue.Domain.Interfaces.Interfaces.Services;

namespace Plurilingue.Application.AppService
{
    public class AnswerAppService : IAnswerAppService
    {
        public readonly IAnswerService _answerService;
        public readonly IMapper _mapper;
        public AnswerAppService(IAnswerService answerService, IMapper mapper)
        {
            _answerService = answerService;
            _mapper = mapper;
        }

        public void RegisterAnswer(AnswerInputModel model) =>
            _answerService.RegisterAnswer(_mapper.Map<AnswerInputModel, Answer>(model));

        public void RegisterBestAnswer(long id) 
            => _answerService.RegisterBestAnswer(id);
    }
}
