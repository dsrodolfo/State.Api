using AutoMapper;
using State.Application.Models.Response;
using State.Domain.Entities;

namespace State.Application.Mappings
{
    public class StateProfile : Profile
    {
        public StateProfile()
        {
            CreateMap<StateEntity, StateResponse>().ReverseMap();
        }
    }
}