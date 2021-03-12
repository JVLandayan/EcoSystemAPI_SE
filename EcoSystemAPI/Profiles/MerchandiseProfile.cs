using AutoMapper;
using EcoSystemAPI.core.Dtos.Merchandise;
using EcoSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoSystemAPI.Profiles
{
    public class MerchandiseProfile :Profile
    {
        public MerchandiseProfile ()
        {
            //Source -> Target
            CreateMap<Merchandise, MerchandiseReadDto>();
            CreateMap<MerchandiseCreateDto, Merchandise>();
            CreateMap<MerchandiseUpdateDto, Merchandise>();
            CreateMap<Merchandise, MerchandiseUpdateDto>();
        }
    }
}
