static class InputParser
{
    public static (List<int>, List<int>) GetInput(string filename)
    {
        var left = new List<int>();
        var right = new List<int>();
        var splitTokens = new string[] { "\t", " ", "   " };
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split(splitTokens, StringSplitOptions.RemoveEmptyEntries);
            left.Add(int.Parse(parts[0]));
            right.Add(int.Parse(parts[1]));
        }
        return (left, right);
    }
}
