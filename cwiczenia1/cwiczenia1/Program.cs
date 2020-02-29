using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace cwiczenia1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode)
            {
                var html = await result.Content.ReadAsStringAsync();
            }

        }
    }
}
