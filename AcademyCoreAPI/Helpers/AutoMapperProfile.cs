using AcademyCoreAPI.DataModels;
using AutoMapper;

namespace AcademyCoreAPI.Helpers
{
    // The automapper profile contains the mapping configuration used by the application
    // , it enables mapping of user entities to dtos and dtos to entities.
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserModel, UserDto>();
            CreateMap<UserDto, UserModel>();
        }
    }
}