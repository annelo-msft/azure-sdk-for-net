using System;
using Azure.Identity;
using Azure.Learn.AppConfig;

namespace SamplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GetConfigurationSetting();

            Console.WriteLine();
            Console.WriteLine("Done.");
            Console.ReadLine();
        }

        public static void GetConfigurationSetting()
        {
            string endpoint = "https://annelo-azconfig-01.azconfig.io";
            ConfigurationClient client = new ConfigurationClient(new Uri(endpoint), new DefaultAzureCredential());

            ConfigurationSetting color = client.GetConfigurationSetting("FontColor");
            ConfigurationSetting greeting = client.GetConfigurationSetting("GreetingText");

            ConsoleColor priorColor = Console.ForegroundColor;

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color.Value);
            Console.WriteLine(greeting.Value);

            Console.ForegroundColor = priorColor;
        }

    }
}
