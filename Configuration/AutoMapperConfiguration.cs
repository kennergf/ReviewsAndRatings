using AutoMapper;
using ReviewsAndRatings.DTO;
using ReviewsAndRatings.Models;

namespace ReviewsAndRatings.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<EstablishmentReview, EstablishmentReviewRetrieveDTO>();
            CreateMap<EstablishmentReviewCreateDTO, EstablishmentReview>();
            CreateMap<EstablishmentReviewCreateDTO, WebsiteFeedback>()
                .ForMember(dest => dest.Feedback, source => source.MapFrom(source => source.WebsiteFeedback));
        }
    }
}