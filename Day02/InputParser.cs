
//Task 2:
//Task 2:
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

