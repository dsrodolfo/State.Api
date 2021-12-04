using AutoMapper;
using State.Api.Entities;
using State.Api.Models.Response;

namespace State.Api.Mappings
{
    public class StateProfile : Profile
    {
        public StateProfile()
        {
            CreateMap<StateEntity, StateResponse>().ReverseMap();
        }
    }
}