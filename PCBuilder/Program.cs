using PCBuilder;
using PCBuilder.Builders;
using PCBuilder.Parts;

var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;


Console.WriteLine("Create office pc:\n");
director.BuildMinimalPC();
Console.Clear();
Console.WriteLine("\n");
Console.WriteLine(builder.GetProduct().ListParts());
Console.WriteLine("\n\nPress enter to continue");
string k = Console.ReadLine();
Console.Clear();
Console.WriteLine("Create gamer pc");
director.BuildGamerPC();
Console.Clear();
Console.WriteLine(builder.GetProduct().ListParts());
Console.WriteLine("\n\nPress enter to exit");
k = Console.ReadLine();

