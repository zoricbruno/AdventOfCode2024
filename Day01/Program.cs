// Part 1:
(List<int> left, List<int> right) = InputParser.GetInput("Input/Input_0a.txt");
Console.WriteLine(DistanceCalculator.CalculateDistance(left, right));
(left, right) = InputParser.GetInput("Input/Input_01.txt");
Console.WriteLine(DistanceCalculator.CalculateDistance(left, right));

// Part 2:
(left, right) = InputParser.GetInput("Input/Input_0b.txt");
Console.WriteLine(SimilarityCalculator.CalculateSimilarityScore(left, right));
(left, right) = InputParser.GetInput("Input/Input_01.txt");
Console.WriteLine(SimilarityCalculator.CalculateSimilarityScore(left, right));
