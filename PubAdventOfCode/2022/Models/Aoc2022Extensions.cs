#region "Usings"

using AdventOfCode.Core.Contracts;
using PubAdventOfCode._2022.Puzzles.DayEleven;
using PubAdventOfCode._2022.Puzzles.DayFive;
using PubAdventOfCode._2022.Puzzles.DayFour;
using PubAdventOfCode._2022.Puzzles.DayNine;
using PubAdventOfCode._2022.Puzzles.DayOne;
using PubAdventOfCode._2022.Puzzles.DaySix;
using PubAdventOfCode._2022.Puzzles.DayThirteen;
using PubAdventOfCode._2022.Puzzles.DayThree;
using PubAdventOfCode._2022.Puzzles.DayTwentyFive;
using PubAdventOfCode._2022.Puzzles.DayTwo;

#endregion

namespace PubAdventOfCode._2022.Models;

public static class Aoc2022Extensions
{
    #region "Properties"

    public static List<IAdventModule> ModulesFor2022 =>
    [
        new SolutionDayOne(),
        new SolutionDayTwo(),
        new SolutionDayThree(),
        new SolutionDayFour(),
        new SolutionDayFive(),
        new SolutionDaySix(),
        new SolutionDayEleven(),
        new SolutionDayThirteen(),
        new SolutionTwentyFive(),
        new SolutionDayNine(),
    ];

    #endregion
}
