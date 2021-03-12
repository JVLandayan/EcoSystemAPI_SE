using EcoSystemAPI.Dtos;
using EcoSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;


namespace EcoSystemAPI.Profiles
{
    public class ArticlesProfile : Profile
    {
        public ArticlesProfile() 
        { 
        CreateMap<Article, ArticleReadDto>();
        CreateMap<ArticleCreateDto, Article>();
        CreateMap<ArticleUpdateDto, Article>();
        CreateMap<Article, ArticleUpdateDto>();
        }
    }
}
