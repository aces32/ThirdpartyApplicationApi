using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyBookingApi.Entites;
using ThirdPartyBookingApi.Models;

namespace ThirdPartyBookingApi.Profiles
{
    public class ThirdPartyBookingProfile : Profile
    {
        public ThirdPartyBookingProfile()
        {
            CreateMap<BookingDTO, ThirdPartyApplication>().ForMember(
                                dest => dest.EmailAddress,
                                opt => opt.MapFrom(src => src.Email));
        }
    }
}
