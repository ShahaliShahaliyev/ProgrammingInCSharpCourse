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
            bool isCountunie;

            HttpClient client = new HttpClient();

            Console.WriteLine("Show facts \n\n \r\n");

            do
            {
                var name = Console.ReadLine();

                string url = "https://api.genderize.io/?name=" + name;

                var result = await client.GetStringAsync(url);

                var genderize = JsonConvert.DeserializeObject<Genderize>(result);

                Console.WriteLine(genderize.Name + " " + genderize.Gender);

                Console.WriteLine(" ");

                Console.WriteLine("to continue:enter true / to stand:enter false");

                isCountunie = Convert.ToBoolean(Console.ReadLine());
            } while (isCountunie);
        }
    }

    public class Genderize
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Probability { get; set; }
        public double Count { get; set; }
    }
}
