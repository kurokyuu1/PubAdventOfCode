#region "Usings"

using AdventOfCode.Core.Contracts;
using PubAdventOfCode._2024.Puzzles.DayFour;
using PubAdventOfCode._2024.Puzzles.DayOne;
using PubAdventOfCode._2024.Puzzles.DayThree;
using PubAdventOfCode._2024.Puzzles.DayTwo;

#endregion

namespace PubAdventOfCode._2024.Models;

public static class Aoc2024Extensions
{
    #region "Properties"

    public static List<IAdventModule> ModulesFor2024 =>
    [
        new SolutionDayOne(),
        new SolutionDayTwo(),
        new SolutionDayThree(),
        new SolutionDayFour(),
    ];

    #endregion
}
