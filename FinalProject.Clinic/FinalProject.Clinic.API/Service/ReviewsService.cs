using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class ReviewsService : IReviewsService
    {
    private readonly IReviewsRepository oReviewsRepository;
        public ReviewsService(IReviewsRepository _oReviewsRepository)
        {
            this.oReviewsRepository = _oReviewsRepository;
        }

        public bool Reviews_Delete(int reviewID)
        {
            return this.oReviewsRepository.Reviews_Delete(reviewID);
        }

        public List<Reviews> Reviews_Get(int? SiteID)
        {
            return this.oReviewsRepository.Reviews_Get(SiteID);
        }

        public bool Reviews_Insert(Reviews oReviews)
        {
            return this.oReviewsRepository.Reviews_Insert(oReviews);
        }
    }
}
