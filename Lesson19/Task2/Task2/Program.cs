using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
       
        static async Task Main(string[] args)
        {
            const string url = "https://catfact.ninja/fact";

            HttpClient httpClient = new HttpClient();

            bool isContinue;

            do
            {
                var result = await httpClient.GetStringAsync(url);
                var properties = JsonConvert.DeserializeObject<Properties>(result);

                Console.WriteLine(properties.Fact +"\n"+ properties.Length);

                Console.WriteLine("*");
                Console.WriteLine("to continue:enter true \n to stop:enter false");

                isContinue = Convert.ToBoolean(Console.ReadLine());


            } while (isContinue);




        }
    }
}
