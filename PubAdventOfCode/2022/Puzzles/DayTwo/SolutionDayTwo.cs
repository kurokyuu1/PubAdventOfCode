namespace PubAdventOfCode._2022.Puzzles.DayTwo;

[AdventModule("Day Two")]
internal sealed class SolutionDayTwo : SolutionBase
{
    #region "Constructor"

    public SolutionDayTwo() : base("2022", "02", true)
    {
    }

    #endregion

    #region "Methods"

    public override async Task RunAsync()
    {
        var data = await InternalReadAllLinesAsync();
        var parsedList = Solver.ParseHandsList(data);
        var riggedList = Solver.ParseOutcomeList(data);

        PuzzleOneResult(parsedList.Sum(Solver.CalculateEndScore));
        PuzzleTwoResult(riggedList.Sum(Solver.CalculateRiggedEndScore));
    }

    #endregion
}
