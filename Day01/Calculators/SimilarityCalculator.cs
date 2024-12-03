internal static class SimilarityCalculator
{

    public static long CalculateSimilarityScore(List<int> left, List<int> right)
    {
        if (left.Count != right.Count)
            throw new ArgumentException("The lists must be of equal length.");

        return left.Select(it => it * right.Count(number => number == it)).Sum();

    }
}