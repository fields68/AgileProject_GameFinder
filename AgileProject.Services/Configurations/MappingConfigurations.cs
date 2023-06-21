using AgileProject.Data.Entities;
using AgileProject.Models.GameModels;
using AgileProject.Models.GameSystemModels;
using AgileProject.Models.GenreModels;
using AgileProject.Models.UserModels;
using AutoMapper;

namespace AgileProject.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<GameEntity, GameCreate>().ReverseMap();
            CreateMap<GameEntity, GameListItem>().ReverseMap();
            CreateMap<GameEntity, GameDetail>().ReverseMap();
            CreateMap<GameEntity, GameEdit>().ReverseMap();

            CreateMap<GameSystemEntity, GameSystemCreate>().ReverseMap();
            CreateMap<GameSystemEntity, GameSystemListItem>().ReverseMap();
            CreateMap<GameSystemEntity, GameSystemDetail>().ReverseMap();
            CreateMap<GameSystemEntity, GameSystemEdit>().ReverseMap();

            CreateMap<GenreEntity, GenreCreate>().ReverseMap();
            CreateMap<GenreEntity, GenreListItem>().ReverseMap();
            CreateMap<GenreEntity, GenreDetail>().ReverseMap();
            CreateMap<GenreEntity, GenreEdit>().ReverseMap();

            CreateMap<UserEntity, UserEntityVM>().ReverseMap();
        }
    }
}