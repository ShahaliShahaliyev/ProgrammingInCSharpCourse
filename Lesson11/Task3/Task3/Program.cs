using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task3
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

                string url = "https://api.nationalize.io/?name=" + name;
                var result = await client.GetStringAsync(url);

                var nationalize = JsonConvert.DeserializeObject<Nationalize>(result);

                Console.WriteLine(nationalize.Name + " " + nationalize.Country);

                Console.WriteLine("to continue:enter true / to stand:enter false");
                foreach (var item in nationalize.Country)
                {
                    Console.WriteLine($"Country:{item.Country_Id},Probablity:{item.Probability}");
                }

                isCountunie = Convert.ToBoolean(Console.ReadLine());
            } while (isCountunie);
        }
    }

    public class Nationalize
    {
        public string Name { get; set; }
        public Country[] Country { get; set; }
    }

    public class Country
    {
        public string Country_Id { get; set; }
        public double Probability { get; set; }
    }

}
