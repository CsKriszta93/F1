using AutoMapper;
using F1TeamManager.Models;
using F1TeamManager.ViewModels;

namespace F1TeamManager.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Team, TeamViewModel>();
            Mapper.CreateMap<TeamViewModel, Team>();
        }
    }
}