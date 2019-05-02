using AutoMapper;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;

namespace Plurilingue.Application.AutoMapper
{
    public class UserProfile : Profile
    {
        protected UserProfile()
        {
            CreateMap<RegisterInputModel, User>();
        }
    }
}
