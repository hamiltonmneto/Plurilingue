using AutoMapper;
using Plurilingue.Application.OutputModels;
using Plurilingue.Application.ViewModels;
using Plurilingue.Domain.Entities;

namespace Plurilingue.Application.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterInputModel, User>();
            CreateMap<LoginInput, User>();
            CreateMap<User, UserOutputModel>();
        }
    }
}
