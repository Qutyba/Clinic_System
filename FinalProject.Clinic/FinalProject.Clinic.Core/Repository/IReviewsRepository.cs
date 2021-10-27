using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Repository
{
    public interface IReviewsRepository
    {
        List<Reviews> Reviews_Get(int? SiteID);
        bool Reviews_Insert(Reviews oReviews);
        bool Reviews_Delete(int reviewID);
    }
}
