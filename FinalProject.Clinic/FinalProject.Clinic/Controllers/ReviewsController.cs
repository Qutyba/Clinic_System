using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReviewsController : Controller
    {
        private readonly IReviewsService oReviewsService;
        public ReviewsController(IReviewsService _oReviewsService)
        {
            this.oReviewsService = _oReviewsService;
        }

        [HttpGet]
        [Route("Reviews_Get/{SiteID}")]
        [ProducesResponseType(typeof(List<Reviews>), StatusCodes.Status200OK)]
        public List<Reviews> Reviews_Get(int? SiteID)
        {
            return this.oReviewsService.Reviews_Get(SiteID);
        }
        [HttpDelete]
        [Route("Reviews_Delete/{reviewID}")]
        public bool Reviews_Delete(int reviewID)
        {
            return this.oReviewsService.Reviews_Delete(reviewID);
        }
        [HttpPost]
        [Route("Reviews_Insert")]
        [ProducesResponseType(typeof(Reviews), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Reviews_Insert([FromBody] Reviews oReviews)
        {
            return this.oReviewsService.Reviews_Insert(oReviews);
        }
    }
}
