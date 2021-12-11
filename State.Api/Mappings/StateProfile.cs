using AutoMapper;
using State.Api.Models.Response;
using State.Domain.Entities;

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