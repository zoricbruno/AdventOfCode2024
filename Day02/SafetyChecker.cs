
//Task 2:
//Task 2:
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

    public static bool IsSafeWhenDampened(List<int> report)
    {
        if (IsSafe(report))
            return true;

        for (int i = 0; i < report.Count; i++)
        {
            var reducedReport = new List<int>(report);
            reducedReport.RemoveAt(i);
            if (IsSafe(reducedReport))
                return true;
        }
        return false;
    }

    public static List<bool> MarkSafe(List<List<int>> reports, Func<List<int>, bool> safetyChecker) => reports.Select(safetyChecker).ToList();
    public static int CountSafeReports(List<List<int>> reports, Func<List<int>, bool> safetyChecker) => reports.Count(safetyChecker);
}

