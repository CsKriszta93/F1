using AutoMapper;
using F1TeamManager.Models;
using F1TeamManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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