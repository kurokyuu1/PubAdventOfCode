using AdventOfCode.Core.Contracts;
using PubAdventOfCode._2024.Puzzles.DayOne;
using PubAdventOfCode._2024.Puzzles.DayTwo;
using static System.Console;

var modules = new List<IAdventModule>
{
    new SolutionDayOne(),
    new SolutionDayTwo()
};

foreach (var item in modules)
{
    WriteLine($"Running module {(Attribute.GetCustomAttribute(item.GetType(), typeof(AdventModuleAttribute)) as AdventModuleAttribute)?.Name}");

    await item.RunAsync();
}

Read();
