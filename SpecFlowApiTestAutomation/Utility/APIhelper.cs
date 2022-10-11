using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace SpecFlowApiTestAutomation.Utility
{
    internal class APIhelper<T>
    {

        public RestClient restClient;
        public RestRequest restRequest;
        public string _baseURL = "https://api.sandbox.elmotalent.com.au/core/v1";


        public RestClient SetUrl()
        {
            Uri baseUri = new Uri(_baseURL);
            var restClient = new RestClient(baseUri);
            restClient.Authenticator = new HttpBasicAuthenticator("puma.api", "7be5f14b8342c4433acdb51e16b7a027");
            return restClient;
        }

        public RestRequest CreateGetRequest(string _endPoint)
        {
            var restRequest = new RestRequest(_endPoint, Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("x-api-key", "dwfWbV16CE1Oxcohga21l5MIHJocUyRv4lZIgwAp");
            restRequest.RequestFormat = DataFormat.Json;

            return restRequest;
        }

        public RestRequest CreatePostRequest(string _endPoint, string _reqBody)
        {
            var restRequest = new RestRequest(_endPoint, Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddParameter("application/json", _reqBody, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreateUpdateRequest(string _endPoint, string _reqBody)
        {
            var restRequest = new RestRequest(_endPoint, Method.Put);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", _reqBody, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreateDeleteRequest(string _endPoint)
        {
            var restRequest = new RestRequest(_endPoint, Method.Delete);
            return restRequest;
        }

        public RestResponse GetResponse(RestClient client, RestRequest request)
        {
            return client.Execute(request);
        }

        public DTO GetContent<DTO>(RestResponse response)
        {
            var content = response.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }

        public dynamic GetDynamicContent<DTO>(RestResponse response)
        {
            //var content = response.Content;               
            dynamic convetedobject = JsonConvert.DeserializeObject(response.Content);
            return convetedobject;
        }


    }
}
