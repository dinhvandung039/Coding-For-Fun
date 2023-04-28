﻿using RealisticDependencies.Interfaces;
using System.Xml;
using System.Xml.Serialization;

namespace Adapter_Wrapper_Pattern.Adapters
{
    public class RecipesApi : IRecipesApi
    {
        private readonly IApplicationLogger _logger;
        private readonly Dictionary<string, Recipe> _database;

        public RecipesApi(IApplicationLogger logger)
        {
            _logger = logger;
            _database = GenerateDatabase();
        }

        public async Task<string> MakeHttpRequestForRecipe(string recipe)
        {
            _logger.LogInfo($"Making HTTP request returning XML for: {recipe}", ConsoleColor.Magenta);
            await Task.Delay(2000);
            var databaseResponse = _database[recipe];
            var xmlSerializer = new XmlSerializer(databaseResponse.GetType());
            await using var stringWriter = new StringWriter();
            await using var writer = XmlWriter.Create(stringWriter, new XmlWriterSettings { Async = true });
            xmlSerializer.Serialize(writer, databaseResponse);
            return stringWriter.ToString();
        }

        private static Dictionary<string, Recipe> GenerateDatabase()
        {
            return new() {
                { "mashed_potatoes", new Recipe("Mashed Potatoes", 30) },
                { "green_beans", new Recipe("Steamed Green Beans", 10) },
                { "red_curry", new Recipe("Red Curry", 60) },
            };
        }
    }
}
