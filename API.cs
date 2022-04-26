
using RestSharp;
using System;
using System.Collections.Generic;

namespace APIConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> idList = new List<long>();
            idList.Add(1);
            idList.Add(2);
            idList.Add(3);
            idList.Add(1333);
            idList.Add(50);
            request(idList);
        }

        public static void request(List<long> idList)
        {
            RestClient client = new RestClient();
            int index = 1;
            foreach (long id in idList) 
            { 
            String url = "https://swapi.dev/api/planets/" + id;

            RestRequest request = new RestRequest(url);
            var response = client.GetAsync(request);
                String preRequestString = "Request number: " + index + " with id: " + id + " - ";
                if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine(preRequestString + response.Result.Content + "\n");
                }
                else
                {
                    Console.WriteLine(preRequestString + "Could not find result! \n");
                }
                index++;
            }
        }
    }
}
