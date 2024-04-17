using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using Microsoft.Extensions.Configuration;

// Your configuration setup
var featureManagement = new Dictionary<string, string> 
{ 
    { "FeatureManagement:Square", "true" }, 
    { "FeatureManagement:Rectangle", "false" }, 
    { "FeatureManagement:Triangle", "true" }
};

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(featureManagement)
    .Build();

// Dependency injection setup
var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();
