using AutoMapper;
using EcoSystemAPI.core.Dtos.Accounts;
using EcoSystemAPI.Dtos;
using EcoSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoSystemAPI.Profiles
{ 
    public class AccountsProfile :Profile
    {
        public AccountsProfile()
        {
            //Source -> Target
            CreateMap<Account, AccountsReadDto>();
            CreateMap<AccountsCreateDto, Account>();
            CreateMap<AccountsUpdateDto, Account>();
            CreateMap<Account, AccountsUpdateDto>();
        }
    }
}
