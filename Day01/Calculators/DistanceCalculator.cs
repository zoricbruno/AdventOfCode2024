static class DistanceCalculator
{
    public static long CalculateDistance(List<int> left, List<int> right)
    {
        if (left.Count != right.Count)
            throw new ArgumentException("The lists must be of equal length.");

        return left.Order()
            .Zip(right.Order())
            .Sum(it => Math.Abs(it.First - it.Second));
    }
}
