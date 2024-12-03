This is the first real public repo I made for [Advent of Code](https://adventofcode.com). Currently there's only 2024, the other years 2022, 2023 would need some cleaning. But maybe if I have time I'll add them here.

I'm doing the challanges with C# and .NET 9.

If you want to run the code by yourself you have to provide your own data inputs from the website.

The project structure is like this:

```txt
- {year}
  -- data
	--- {day with leading 0}
	  --- test.txt
	  --- input.txt
- Models (if specific to the day if used often you can change it
  -- Day{DayNumber in words} // example DayOne, DayTwo...
- Puzzles
  -- Day{DayNumber in words} // example DayOne, DayTwo
    - File/Class Name: Solution{DayNumber in Words}.cs
    - Classes are constructed like this:
```
```cs
  [AdventModule("Day One")]
  public sealed class SolutionDayOne : SolutionBase
  {
      public SolutionDayOne() : base("2024","01", true) {}
  
      public override Task RunAsync() => null;
  }
  ```
In the `Program.cs` then you have to write this:
```cs
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
```

And this should be it.
