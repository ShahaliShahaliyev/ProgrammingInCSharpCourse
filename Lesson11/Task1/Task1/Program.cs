using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            const string url = "https://www.boredapi.com/api/activity";

            bool isCountunie;

            HttpClient client = new HttpClient();

            Console.WriteLine("Show facts \n\n \r\n");
            
            do
            {
                var result = await client.GetStringAsync(url);

                var bored = JsonConvert.DeserializeObject<Bored>(result);

                Console.WriteLine(bored.Activity);

                Console.WriteLine("___");

                Console.WriteLine("to continue:enter true / to stand:enter false");

                isCountunie = Convert.ToBoolean(Console.ReadLine());
            } while (isCountunie);
        }
    }

    public class Bored
    {
        public string Activity { get; set; }
        public string Type { get; set; }
        public double Participants { get; set; }
        public double Price { get; set; }
        public double Key { get; set; }
        public double Accessibility { get; set; }
    }
}
