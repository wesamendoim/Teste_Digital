using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Digital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherForecast propietiesCard = new WeatherForecast();
            LogicCard logic = new LogicCard();

            int[] arrayColletion = { 2, 3, 4 };

            logic.ReverseArrayKTimes(arrayColletion, 2);

            for (int i = 0; i < arrayColletion.Length; i++)
            {
                Console.WriteLine(arrayColletion[i]); 

            }

            string cvvNumber = arrayColletion[0].ToString() + arrayColletion[1].ToString() + arrayColletion[2].ToString();

            propietiesCard.CVV = int.Parse(cvvNumber);
        
            logic.CardNumber("2231154121814026");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
