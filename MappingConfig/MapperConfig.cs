using Blogapi.DTO.Product;
using AutoMapper;
using Blogapi.Model;

namespace Blogapi.MappingConfig
{
    public class MapperConfig : Profile//ublic class MapperConfig : Profile is part of the AutoMapper library, and it defines a configuration class for mapping between objects
    {
        public MapperConfig()
        {
            CreateMap<PostDTO, Post>().ReverseMap();
            // Add other mappings here
        }
    }
}