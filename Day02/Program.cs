var reports = InputParser.GetInput("Input//Input_0a.txt");
Console.WriteLine(SafetyChecker.CountSafeReports(reports));
reports = InputParser.GetInput("Input//Input_01.txt");
Console.WriteLine(SafetyChecker.CountSafeReports(reports));

static class SafetyChecker
{
    private const int MaxAllowedJump = 3;
    private const int MinAllowedJump = 1;

    public static bool IsSafe(List<int> report)
    {
        bool isDecreasing = false;
        bool isIncreasing = false;
        if (report[0] > report[1])
            isDecreasing = true;
        else if (report[0] < report[1])
            isIncreasing = true;
        else
            return false;

        for (int i = 1; i < report.Count; i++)
        {
            int difference = report[i - 1] - report[i];
            if (isIncreasing && difference >= 0)
                return false;
            if (isDecreasing && difference <= 0)
                return false;
            if (Math.Abs(difference) < MinAllowedJump || Math.Abs(difference) > MaxAllowedJump)
                return false;
        }

        return true;
    }

    public static int CountSafeReports(List<List<int>> reports) => reports.Count(IsSafe);
}

static class InputParser
{
    public static List<List<int>> GetInput(string filename)
    {
        var inputs = File.ReadAllLines(filename)
            .Select(it => it.Split(" "))
            .Select(it => Array.ConvertAll(it, int.Parse).ToList())
            .ToList();
        return inputs;
    }
}

