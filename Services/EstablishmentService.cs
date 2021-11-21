using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ReviewsAndRatings.DTO;
using ReviewsAndRatings.Interfaces;
using ReviewsAndRatings.Models;

namespace ReviewsAndRatings.Services
{
    public class EstablishmentService : IEstablishmentService
    {
        private readonly IEstablishmentReviewRepository _establishmentReviewRepository;
        private readonly IWebsiteFeedbackRepository _websiteFeedbackRepository;
        private readonly IMapper _mapper;
        public EstablishmentService(IEstablishmentReviewRepository establishmentReviewRepository, IWebsiteFeedbackRepository websiteFeedbackRepository, IMapper mapper)
        {
            _establishmentReviewRepository = establishmentReviewRepository;
            _websiteFeedbackRepository = websiteFeedbackRepository;
            _mapper = mapper;
        }

        public Task<List<EstablishmentReviewRetrieveDTO>> GetReview(Guid IdEstablishment)
        {
            // TODO Change the mocked value for a query on the Database by IdEstablishment
            var result = new List<EstablishmentReviewRetrieveDTO>();
            result.Add(new EstablishmentReviewRetrieveDTO
            {
                IdEstablishment = IdEstablishment,
                IdCustomer = Guid.NewGuid(),
                Rating = Enums.Rating.Good.ToString(),
                Review = "This is a mocked review!"
            });
            result.Add(new EstablishmentReviewRetrieveDTO
            {
                IdEstablishment = IdEstablishment,
                IdCustomer = Guid.NewGuid(),
                Rating = Enums.Rating.Good.ToString(),
                Review = "This is a mocked review!"
            });
            return Task.FromResult(result);
        }

        public Task<EstablishmentReviewDTO> CreateReview(EstablishmentReviewDTO establishmentReview)
        {
            // TODO Need to check if the establishment exists
            _establishmentReviewRepository.Add(_mapper.Map<EstablishmentReview>(establishmentReview));
            // If Exist Feedback on the website
            if (!string.IsNullOrEmpty(((EstablishmentReviewCreateDTO)establishmentReview).WebsiteFeedback))
            {
                _websiteFeedbackRepository.Add(_mapper.Map<WebsiteFeedback>(establishmentReview));
            }
            return Task.FromResult(establishmentReview);
        }

    }
}