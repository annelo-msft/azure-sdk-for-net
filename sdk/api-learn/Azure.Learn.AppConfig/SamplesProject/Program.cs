using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Learn.AppConfig;

namespace SamplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GetConfigurationSettingIfChanged().Wait();

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

        public static async Task GetConfigurationSettingIfChanged()
        {
            string endpoint = "https://annelo-azconfig-01.azconfig.io";
            ConfigurationClient client = new ConfigurationClient(new Uri(endpoint), new DefaultAzureCredential());

            Dictionary<string, ConfigurationSetting> settingCache = new Dictionary<string, ConfigurationSetting>();
            await InitializeCacheAsync(client, settingCache);
            PrintGreeting(settingCache);

            for (int i = 0; i < 4; i++)
            {
                await UpdateCacheAsync(client, settingCache);
                PrintGreeting(settingCache);

                await Task.Delay(2000);
            }
        }

        private static async Task InitializeCacheAsync(ConfigurationClient client, Dictionary<string, ConfigurationSetting> cache)
        {
            cache["FontColor"] = await client.GetConfigurationSettingAsync("FontColor");
            cache["GreetingText"] = await client.GetConfigurationSettingAsync("GreetingText");
        }

        public static async Task UpdateCacheAsync(ConfigurationClient client, Dictionary<string, ConfigurationSetting> cache)
        {
            cache["FontColor"] = await client.GetConfigurationSettingAsync(cache["FontColor"], onlyIfChanged: true);
            cache["GreetingText"] = await client.GetConfigurationSettingAsync(cache["GreetingText"], onlyIfChanged: true);
        }

        public static void PrintGreeting(Dictionary<string, ConfigurationSetting> cache)
        {
            ConsoleColor priorColor = Console.ForegroundColor;

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cache["FontColor"].Value);
            Console.WriteLine(cache["GreetingText"].Value);

            Console.ForegroundColor = priorColor;
        }
    }
}
