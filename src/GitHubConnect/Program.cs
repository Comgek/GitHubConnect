using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubConnect
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new RestClient("http://github.com");
            var request = new RestRequest("/repos/codercampsjosh/FirstGitHub/blob/master/app.js");

            var result = client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response.Content);
            });

            Console.ReadLine();
        }
    }
}

