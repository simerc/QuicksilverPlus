using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EPiServer.Reference.Commerce.Shared.Models;

namespace EPiServer.Reference.Commerce.Shared.AutomapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ApiProductResult, ProductItem>()
                    .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => Int32.Parse(src.ResultId)))
                    .ForMember(dest => dest.DaysOfWeek, opt => opt.MapFrom(src => DaysOfWeek.Sunday))
                    .ForMember(dest => dest.Date,
                        opt => opt.MapFrom(src => DateTime.ParseExact(src.ResultDate, "dd/MM/yyyy", null)));
        }
    }
}
