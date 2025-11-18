string GetCorectSign()
{
    string sign = Console.ReadLine()!;

    //while (!firstSign.Equals(allowedSigns[0], stringComparison) && !firstSign.Equals(allowedSigns[1], stringComparison) && !firstSign.Equals(allowedSigns[2], stringComparison))
    while (!allowedSigns.Contains(firstSign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Player 1, choose correct sign ({string.Join('/', allowedSigns)})");
        firstSign = Console.ReadLine()!;
    }
    return sign;
}

Console.WriteLine("Let's play Rock-Paper-Scissors");
const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
//string firstAllowedSign = "rock";
//string secondAllowedSign = "paper";
//string thirdAllowedSign = "scissors";
List<string> allowedSigns = ["rock", "paper", "scissors"];

Console.WriteLine($"Player 1, choose your sign ({string.Join('/', allowedSigns)})");
//Console.WriteLine($"Player 1, choose your sign ({string.Join("/", allowedSigns)})");
//Console.WriteLine($"Player 1, choose your sign ({allowedSigns[0]}/{allowedSigns[1]}/{allowedSigns[2]})");



Console.WriteLine($"Player 2, choose your sign ({string.Join('/', allowedSigns)})");
string secondSign = Console.ReadLine()!;

if (firstSign.Equals(secondSign, StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("It's a tie!");
}
else if ((firstSign.Equals(allowedSigns[0], stringComparison) && secondSign.Equals(allowedSigns[2], stringComparison))
    || (firstSign.Equals(allowedSigns[1], stringComparison) && secondSign.Equals(allowedSigns[0], stringComparison))
    || (firstSign.Equals(allowedSigns[2], stringComparison) && secondSign.Equals(allowedSigns[1], stringComparison)))
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}