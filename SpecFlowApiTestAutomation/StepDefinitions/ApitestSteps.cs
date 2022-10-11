using SpecFlowApiTestAutomation.DTO;
using SpecFlowApiTestAutomation.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowApiTestAutomation.StepDefinitions
{
    [Binding]
    public class ApitestSteps
    {
        [Given(@"Api Get endpoint")]
        public void GivenApiGetEndpoint()
        {
            Console.WriteLine("API Testing Start");

        }


        [When(@"Api Get requested")]
        public void WhenApiGetRequested()
        {
            var user = new APIhelper<ListOfUsersDTO>();
            var url = user.SetUrl();
            var request = user.CreateGetRequest("/users");
            var response = user.GetResponse(url, request);

            HttpStatusCode statusCode = response.StatusCode;
            int StatusCode = (int)statusCode;
            Console.WriteLine("StatusCode = " + StatusCode);

            dynamic data = user.GetContent<List<ListOfUsersDTO>>(response);
            Console.WriteLine("ID = " + data[0].id);
            Console.WriteLine("Identifier = " + data[0].identifier);
            Console.WriteLine("firstName = " + data[0].firstName);
            Console.WriteLine("lastName = " + data[0].lastName);
            Console.WriteLine("username = " + data[0].username);


            //var name = (string)data.Name; // Jon Smith
            //var age = (int)data.Age;      // 42

            //var address = data.Address;
            //var city = (string)data.City;   // New York
            //var state = (string)data.State; // NY
        }

        [Then(@"Verify Api Response User Details")]
        public void ThenVerifyApiResponseUserDetails()
        {
            Console.WriteLine("API Testing End");
        }

    }
}