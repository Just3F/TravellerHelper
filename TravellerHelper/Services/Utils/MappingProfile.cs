using AutoMapper;
using TravellerHelper.Models;
using TravellerHelper.ViewModels;

namespace TravellerHelper.Services.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<tblFlight, FlightViewModel>();
            CreateMap<FlightViewModel, tblFlight>();
        }
    }
}
