using AutoMapper;
using RestaurantEntityLayer.Concrete;
using RestaurantWebUI.Dtos.AboutDto;
using RestaurantWebUI.Dtos.BookingDto;
using RestaurantWebUI.Dtos.GuestDto;
using RestaurantWebUI.Dtos.LoginDto;
using RestaurantWebUI.Dtos.RegisterDto;
using RestaurantWebUI.Dtos.StaffDto;
using RestaurantWebUI.Dtos.SubscribeDto;
using RestaurantWebUI.Dtos.TestimonialDto;

namespace RestaurantWebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
        }
    }
}
