using AutoMapper;
using BenDan.Core.Entities;
using BenDan.Infrastructure.Resources;

namespace BenDan.Api.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostResource>()
                .ForMember(dest => dest.UpDateTime, opt => opt.MapFrom(src => src.LastModified));

            CreateMap<PostResource,Post>();
        }
    }
}
