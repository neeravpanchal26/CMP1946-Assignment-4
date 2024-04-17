using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using Microsoft.Extensions.Configuration;
using Geometry.Library;

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

var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();
if (await featureManager.IsEnabledAsync("Square"))
{
    // Provide access to Square
    var square = new Square(5);
    Console.WriteLine("Square - Area: " + square.CalculateArea() + ", Perimeter: " + square.CalculatePerimeter());
}
else
{
    Console.WriteLine("Square feature is disabled.");
}

if (await featureManager.IsEnabledAsync("Rectangle"))
{
    // Provide access to Rectangle
    var rectangle = new Rectangle(4, 6);
    Console.WriteLine("Rectangle - Area: " + rectangle.CalculateArea() + ", Perimeter: " + rectangle.CalculatePerimeter());
}
else
{
    Console.WriteLine("Rectangle feature is disabled.");
}

if (await featureManager.IsEnabledAsync("Triangle"))
{
    // Provide access to Triangle
    var triangle = new Triangle(3, 4, 5);
    Console.WriteLine("Triangle - Area: " + triangle.CalculateArea() + ", Perimeter: " + triangle.CalculatePerimeter());
}
else
{
    Console.WriteLine("Triangle feature is disabled.");
}