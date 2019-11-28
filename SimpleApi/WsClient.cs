using CluedInAssignment.WsEntities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace CluedInAssignment
{
    class WsClient : IClient
    {
        private RestClient client;

        public WsClient(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }


        public List<CompanyDetails> GetAllCompanies()
        {
            RestRequest request = new RestRequest("companies", Method.GET) { RequestFormat = DataFormat.Json };
            IRestResponse<List<CompanyDetails>> response = client.Execute<List<CompanyDetails>>(request);
            ResponseHandler(response.StatusCode, response.StatusDescription);
            return response.Data;
        }


        public List<Customers> GetCustomers(int id)
        {
            RestRequest request = new RestRequest("companies/" + id + "/customers", Method.GET) { RequestFormat = DataFormat.Json };
            IRestResponse<List<Customers>> response = client.Execute<List<Customers>>(request);
            ResponseHandler(response.StatusCode, response.StatusDescription);
            return response.Data;
        }


        public List<Employees> GetEmployees(int id)
        {
            RestRequest request = new RestRequest("companies/" + id + "/employees", Method.GET) { RequestFormat = DataFormat.Json };
            IRestResponse<List<Employees>> response = client.Execute<List<Employees>>(request);
            ResponseHandler(response.StatusCode, response.StatusDescription);
            return response.Data;
        }

        #region Private Helpers

        /// <summary>
        /// Helper response handler could be advanced logging to cloudwatch etc...
        /// </summary>
        /// <param name="StatusCode"></param>
        /// <param name="StatusDescription"></param>
        /// <returns></returns>
        private void ResponseHandler(HttpStatusCode StatusCode, string StatusDescription)
        {

            if (StatusCode != HttpStatusCode.OK)
                throw new ArgumentException("Web service call failed " + StatusDescription);
        }

        #endregion
    }
}
