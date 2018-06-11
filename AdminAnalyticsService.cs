using Web.Data.Providers;
using Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Services
{
    public class AdminAnalyticsService : IAdminAnalyticsService
    {
        readonly IDataProvider dataProvider;

        public AdminAnalyticsService(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public string GetAll()
        {
            var jsonResult = new StringBuilder();
            dataProvider.ExecuteCmd(
                "AdminAnalytics_GetAll",
                inputParamMapper: null,
                singleRecordMapper: (reader, resultSetId) =>
                {
                    jsonResult.Append(reader.GetString(0));
                });
            return jsonResult.ToString();
        }

        public string GetByDay()
        {
            var jsonResult = new StringBuilder();
            dataProvider.ExecuteCmd(
                "AdminAnalytics_GetByDay",
                inputParamMapper: null,
                singleRecordMapper: (reader, resultSetId) =>
                {
                    jsonResult.Append(reader.GetString(0));
                });
            return jsonResult.ToString();
        }

        public string GetByWeek()
        {
            var jsonResult = new StringBuilder();
            dataProvider.ExecuteCmd(
                "AdminAnalytics_GetByWeek",
                inputParamMapper: null,
                singleRecordMapper: (reader, resultSetId) =>
                {
                    jsonResult.Append(reader.GetString(0));
                });
            return jsonResult.ToString();
        }

        public string GetByMonth()
        {
            var jsonResult = new StringBuilder();
            dataProvider.ExecuteCmd(
                "AdminAnalytics_GetByMonth",
                inputParamMapper: null,
                singleRecordMapper: (reader, resultSetId) =>
                {
                    jsonResult.Append(reader.GetString(0));
                });
            return jsonResult.ToString();
        }

        public string GetBy6Months()
        {
            var jsonResult = new StringBuilder();
            dataProvider.ExecuteCmd(
                "AdminAnalytics_GetBy6Months",
                inputParamMapper: null,
                singleRecordMapper: (reader, resultSetId) =>
                {
                    jsonResult.Append(reader.GetString(0));
                });
            return jsonResult.ToString();
        }

        public string GetByYear()
        {
            var jsonResult = new StringBuilder();
            dataProvider.ExecuteCmd(
                "AdminAnalytics_GetByYear",
                inputParamMapper: null,
                singleRecordMapper: (reader, resultSetId) =>
                {
                    jsonResult.Append(reader.GetString(0));
                });
            return jsonResult.ToString();
        }
    }
}
