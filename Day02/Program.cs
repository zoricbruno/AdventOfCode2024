var reports = InputParser.GetInput("Input//Input_0a.txt");
Console.WriteLine(SafetyChecker.CountSafeReports(reports, SafetyChecker.IsSafe));
reports = InputParser.GetInput("Input//Input_01.txt");
Console.WriteLine(SafetyChecker.CountSafeReports(reports, SafetyChecker.IsSafe));

//Task 2:
reports = InputParser.GetInput("Input//Input_0b.txt");
Console.WriteLine(SafetyChecker.CountSafeReports(reports, SafetyChecker.IsSafeWhenDampened));
//Task 2:
reports = InputParser.GetInput("Input//Input_01.txt");
Console.WriteLine(SafetyChecker.CountSafeReports(reports, SafetyChecker.IsSafeWhenDampened));

