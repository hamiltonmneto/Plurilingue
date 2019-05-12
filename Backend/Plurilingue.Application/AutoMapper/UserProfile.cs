using AutoMapper;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;

namespace Plurilingue.Application.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterInputModel, User>();
        }
    }
}
