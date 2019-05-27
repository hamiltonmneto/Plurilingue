using AutoMapper;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;

namespace Plurilingue.Application.AutoMapper
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<AnswerInputModel, Answer>()
                .ForMember(de => de.TextContent, a => a.MapFrom(para => para.AnswerContent));
        }
    }
}
