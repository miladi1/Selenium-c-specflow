using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Newtonsoft.Json;

namespace TestOptima.Utilities
{



    public static class Env
    {

        public static string BaseUrl = "https://frwadevoptima0001.azurewebsites.net/";
        private static readonly string ConfigFilePath = "C:\\Users\\M'Amine\\source\\repos\\TestUIOptima\\TestOptima\\config.json";
        private static dynamic Config;


       
        public static void Load()
        {
          // string relativePath = "../config.json";
          //string rootPath = Path.Combine(Directory.GetCurrentDirectory(), relativePath);
          // string jsonContents = File.ReadAllText(rootPath);
            string configJson = File.ReadAllText(ConfigFilePath);
            Config = JsonConvert.DeserializeObject(configJson);
        }

        public static string GetVariable(string variable)
        {
            var value = Config?[variable]?.ToString();
            return value ?? string.Empty;
        }
      
    }
}

