using Newtonsoft.Json.Linq;
using Models.Responses;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers.Api
{
    public class AdminAnalyticsController : ApiController
    {
        readonly IAdminAnalyticsService adminAnalyticsService;

        public AdminAnalyticsController(IAdminAnalyticsService adminAnalyticsService)
        {
            this.adminAnalyticsService = adminAnalyticsService;
        }

        [Route("api/admin-analytics"), HttpGet]
        public HttpResponseMessage GetAll()
        {
            ItemResponse<JRaw> itemResponse = new ItemResponse<JRaw>();
            itemResponse.Item = new JRaw(adminAnalyticsService.GetAll());
            return Request.CreateResponse(HttpStatusCode.OK, itemResponse);
        }

        [Route("api/admin-analytics/day"), HttpGet]
        public HttpResponseMessage GetByDay()
        {
            ItemResponse<JRaw> itemResponse = new ItemResponse<JRaw>();
            itemResponse.Item = new JRaw(adminAnalyticsService.GetByDay());
            return Request.CreateResponse(HttpStatusCode.OK, itemResponse);
        }

        [Route("api/admin-analytics/week"), HttpGet]
        public HttpResponseMessage GetByWeek()
        {
            ItemResponse<JRaw> itemResponse = new ItemResponse<JRaw>();
            itemResponse.Item = new JRaw(adminAnalyticsService.GetByWeek());
            return Request.CreateResponse(HttpStatusCode.OK, itemResponse);
        }

        [Route("api/admin-analytics/month"), HttpGet]
        public HttpResponseMessage GetByMonth()
        {
            ItemResponse<JRaw> itemResponse = new ItemResponse<JRaw>();
            itemResponse.Item = new JRaw(adminAnalyticsService.GetByMonth());
            return Request.CreateResponse(HttpStatusCode.OK, itemResponse);
        }

        [Route("api/admin-analytics/6months"), HttpGet]
        public HttpResponseMessage GetBy6Months()
        {
            ItemResponse<JRaw> itemResponse = new ItemResponse<JRaw>();
            itemResponse.Item = new JRaw(adminAnalyticsService.GetBy6Months());
            return Request.CreateResponse(HttpStatusCode.OK, itemResponse);
        }

        [Route("api/admin-analytics/year"), HttpGet]
        public HttpResponseMessage GetByYear()
        {
            ItemResponse<JRaw> itemResponse = new ItemResponse<JRaw>();
            itemResponse.Item = new JRaw(adminAnalyticsService.GetByYear());
            return Request.CreateResponse(HttpStatusCode.OK, itemResponse);
        }
    }
}
