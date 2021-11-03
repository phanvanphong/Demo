using AutoMapper;
using DemoDotNet5.Models;
using DemoDotNet5.ViewModel;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category,CategoryViewModel >().ReverseMap();
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>()
            .ForMember(dest =>
                dest.ImageName,
                opt => opt.MapFrom(src => src.Image)
            )
            //.ForMember(dest =>
            //    dest.CategoryName,
            //    opt => opt.MapFrom(src => src.Category.Name)
            //)
            .ReverseMap()
            .ForMember(dest =>
                dest.Name,
                opt => opt.MapFrom(src => src.ImageName)
            );

            // Thuộc tính UserProfileFullName trong UserProfileViewModel = UserProfile.FirstName + UserProfile.LastName
            CreateMap<Customer, CustomerViewModel>()
            .ForMember(dest =>
                dest.UserProfileFullName,
                opt => opt.MapFrom(src => src.UserProfile.FirstName + " " + src.UserProfile.LastName)
            );

        }
    }
}
