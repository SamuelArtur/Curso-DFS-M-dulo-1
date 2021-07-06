using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Domains.Models;
using WebApplication.Resources;

namespace WebApplication.Mapping
{
    public class ResourceToModelProfile: AutoMapper.Profile
    {
       public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();    
        }
    }
}
