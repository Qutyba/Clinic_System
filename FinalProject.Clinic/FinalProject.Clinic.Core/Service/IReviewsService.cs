using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
    public interface IReviewsService
    {
        List<Reviews> Reviews_Get(int? SiteID);
        bool Reviews_Insert(Reviews oReviews);
        bool Reviews_Delete(int reviewID);
    }
}
