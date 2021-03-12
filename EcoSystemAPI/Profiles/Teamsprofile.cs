using AutoMapper;
using EcoSystemAPI.core.Dtos.Teams;
using EcoSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoSystemAPI.Profiles
{
    public class Teamsprofile : Profile
    {
            public Teamsprofile()
            {
                //Source -> Target
                CreateMap<Teams, TeamsReadDto>();
                CreateMap<TeamsCreateDto, Teams>();
                CreateMap<TeamsUpdateDto, Teams>();
                CreateMap<Teams, TeamsUpdateDto>();
            }

    }
}
