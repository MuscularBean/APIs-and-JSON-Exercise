using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ron: {quote.Ron()}");
                Console.WriteLine("------");
                Console.WriteLine($"Kanye: {quote.Kanye()}");
                Console.WriteLine("------");

            }
            Console.WriteLine("-------");
            var client1 = new HttpClient();
            var forecast = new OpenWeatherMapAPI(client1);

    
             var temperature = forecast.Forecast();
             Console.WriteLine($"City: Mesa \nTemp: {temperature}");
            
            

        }
    }
}
