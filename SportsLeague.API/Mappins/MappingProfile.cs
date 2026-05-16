using AutoMapper;
using SportsLeague.API.DTO_s.Request;
using SportsLeague.API.DTO_s.Response;
using SportsLeague.Domain.Entities;

namespace SportsLeague.API.Mappins
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Team mappings
            CreateMap<TeamRequestDTO, Team>();
            CreateMap<Team, TeamResponseDTO>();

            // Player mappings
            CreateMap<PlayerRequestDTO, Player>();
            CreateMap<Player, PlayerResponseDTO>()
                .ForMember(
                    dest => dest.TeamName,
                    opt => opt.MapFrom(src => src.Team.Name));
        }


    }
}
