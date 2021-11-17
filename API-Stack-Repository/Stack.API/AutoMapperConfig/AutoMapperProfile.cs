using AutoMapper;
using Stack.DTOs.Models;
using Stack.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack.API.AutoMapperConfig
{
    public class AutoMapperProfile : Profile
    {
        //Auto Mapper Configuration File . 
        public AutoMapperProfile()
        {

            //Mirror mapping between an entity and it's DTO . 

            //Mapping an entity and it's DTO while ignorig cyclic dependancy errors . 
            CreateMap<Customer, CustomerDTO>().ReverseMap();

            CreateMap<Vehicle, VehicleDTO>()
            .ReverseMap();

            //.ForMember(dest => dest.Department, opt => opt.Ignore())


        }
    }
}
