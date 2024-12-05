using AdventOfCode.Core.Contracts;
using PubAdventOfCode._2023.Puzzles.DayEight;
using PubAdventOfCode._2023.Puzzles.DayFive;
using PubAdventOfCode._2023.Puzzles.DayFour;
using PubAdventOfCode._2023.Puzzles.DayNine;
using PubAdventOfCode._2023.Puzzles.DayOne;
using PubAdventOfCode._2023.Puzzles.DaySeven;
using PubAdventOfCode._2023.Puzzles.DaySix;
using PubAdventOfCode._2023.Puzzles.DayThree;
using PubAdventOfCode._2023.Puzzles.DayTwo;

namespace PubAdventOfCode._2023.Models
{
    public static class Aoc2023Extensions
    {
        public static List<IAdventModule> ModulesFor2023 =>
        [
            new SolutionDayOne(),
            new SolutionDayTwo(),
            new SolutionDayThree(),
            new SolutionDayFour(),
            new SolutionDayFive(),
            new SolutionDaySix(),
            new SolutionDaySeven(),
            new SolutionDayEight(),
            new SolutionDayNine(),
        ];
    }
}
