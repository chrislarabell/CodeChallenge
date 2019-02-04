namespace CodeChallenge.API.Models
{
    using AutoMapper;
    using CodeChallenge.Core.Entities;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Launchpad, LaunchpadDto>();
        }
    }
}
