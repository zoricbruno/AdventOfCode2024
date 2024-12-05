using System.Text.RegularExpressions;

var input = File.ReadAllText("Input/Input_0a.txt");
Console.WriteLine(input);

var mulPattern = new Regex(@"mul\([0-9]{1,3},[0-9]{1,3}\)");
Match match = mulPattern.Match(input);
Console.WriteLine(match);
while (match.Success)
{
    match = match.NextMatch();
    Console.WriteLine(match);
    match.Value.
}
