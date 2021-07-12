using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using ProductivityTools.GetTask3.Contract;
using ProductivityTools.MasterConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Client
{
    public class GetTaskHttpClient
    {
        static string URL = "http://apigettask3.productivitytools.tech:8040/api/";// Consts.EndpointAddress;
       // static string URL = "http://localhost:5513/api/";// Consts.EndpointAddress;

        static IConfigurationRoot configuration = new ConfigurationBuilder().AddMasterConfiguration().Build();

        private static string token;
        private static string Token
        {
            get
            {
                if (string.IsNullOrEmpty(token))
                {
                    Console.WriteLine("token is empty need to call identity server");
                    var client = new HttpClient();

                    var disco = client.GetDiscoveryDocumentAsync("https://identityserver.productivitytools.tech:8010/").Result;
                    Console.WriteLine($"Discovery server{disco}");
                    if (disco.IsError)
                    {
                        Console.WriteLine(disco.Error);
                    }

                    Console.WriteLine("GetTask3Cmdlet secret");
                    Console.WriteLine(configuration["GetTask3Cmdlet"]);

                    var tokenResponse = client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                    {
                        Address = disco.TokenEndpoint,

                        ClientId = "GetTask3Cmdlet",
                        ClientSecret = configuration["GetTask3Cmdlet"],
                        Scope = "GetTask3.API"
                    }).Result;

                    Console.WriteLine("Token response pw:");
                    Console.WriteLine(tokenResponse.AccessToken);
                    Console.WriteLine(tokenResponse.Error);

                    if (tokenResponse.IsError)
                    {
                        Console.WriteLine(tokenResponse.Error);
                    }

                    Console.WriteLine(tokenResponse.Json);
                    token = tokenResponse.AccessToken;
                }
                return token;
            }
        }




        public static async Task<T> Post2<T>(string controller, string action, object obj,Action<string> log)
        {
            log($"Performing Post under address {URL}");
            HttpClient client = new HttpClient(new LoggingHandler(new HttpClientHandler(),log));
            client.BaseAddress = new Uri(URL+controller+"/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.SetBearerToken(Token);

            HttpResponseMessage response = await client.PostAsJsonAsync(action, obj);
            if (response.IsSuccessStatusCode)
            {
                T result = await response.Content.ReadAsAsync<T>();
                return result;
            }
            throw new Exception(response.ReasonPhrase);

        }

        //private static T Post<T>(string action, string jsonContent)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(URL);

        //    // Add an Accept header for JSON format.
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        //    //HttpContent content = new StringContent("{Name: \"TaskOnSecondLevel2\",ParentId: 3 }", Encoding.UTF8, "application/json"); 
        //    HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json"); 
        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    // List data response.
        //    //HttpResponseMessage response = client.PostAsync("Add",content).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
        //    HttpResponseMessage response = client.PostAsync(action, content).Result;  // Blocking call! Program will wait here until a 
        //    if (response.IsSuccessStatusCode)
        //    {
        //        // Parse the response body.
        //        var dataObjects = response.Content.ReadAsAsync<T>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
        //        client.Dispose();
        //        return dataObjects;
        //    }
        //    else
        //    {
        //        client.Dispose();
        //        throw new Exception(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
        //    }
        //}
    }
}
