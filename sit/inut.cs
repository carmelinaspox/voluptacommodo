using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        try
        {
            // Asynchronously call the API and get the response
            HttpResponseMessage response = await client.GetAsync("https://www.example.com            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            // Here, responseBody contains the JSON response from the API
            Console.WriteLine(responseBody);
        }
        catch(HttpRequestException e)
        {
            // Handle any errors here
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ",e.Message);
        }
    }
}
