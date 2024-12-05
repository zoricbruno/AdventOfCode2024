using System.Text.RegularExpressions;

// Task 1:
var input = File.ReadAllText("Input/Input_0a.txt");
Console.WriteLine(MemoryUnscrambler.Multiply(input));
input = File.ReadAllText("Input/Input_01.txt");
Console.WriteLine(MemoryUnscrambler.Multiply(input));

// Task 2:
input = File.ReadAllText("Input/Input_0b.txt");
Console.WriteLine(MemoryUnscrambler.MultiplyWithConditions(input));
input = File.ReadAllText("Input/Input_01.txt");
Console.WriteLine(MemoryUnscrambler.MultiplyWithConditions(input));

class MemoryUnscrambler
{
    public static int MultiplyWithConditions(string input)
    {
        Regex mulPattern = new Regex(@"mul\([0-9]{1,3},[0-9]{1,3}\)|do\(\)|don't\(\)");
        Match match = mulPattern.Match(input);
        int total = 0;
        bool shouldMultiply = true;
        while (match.Success)
        {
            if (match.Value == "do()")
            {

                shouldMultiply = true;
            }
            else if (match.Value == "don't()")
            {
                shouldMultiply = false;
            }
            else
            {
                var parts = match.Value.Split(
                    new char[] { 'm', 'u', 'l', ',', '(', ')' },
                    StringSplitOptions.RemoveEmptyEntries
                );
                if (shouldMultiply)
                    total += int.Parse(parts[0]) * int.Parse(parts[1]);
            }
            match = match.NextMatch();
        }
        return total;
    }

    public static int Multiply(string input)
    {
        Regex mulPattern = new Regex(@"mul\([0-9]{1,3},[0-9]{1,3}\)");
        Match match = mulPattern.Match(input);
        int total = 0;
        while (match.Success)
        {
            var parts = match.Value.Split(
                new char[] { 'm', 'u', 'l', ',', '(', ')' },
                StringSplitOptions.RemoveEmptyEntries
            );
            total += int.Parse(parts[0]) * int.Parse(parts[1]);
            match = match.NextMatch();
        }
        return total;
    }
}


