using AutoMapper;
using MyfirstApi.Core.DTOs;
using MyFirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstApi.Core.Mappers
{
    public class CategoryProfile : Profile
    {
         public CategoryProfile()
         {
            
            CreateMap<Category,CategoryDTO>();
            CreateMap<CreateCategoryDTO, Category>();        
         }
    }
}
