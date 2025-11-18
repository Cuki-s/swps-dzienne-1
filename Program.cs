List<string> allowedSigns = ["rock", "paper", "scissors"];
string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, choose your sign ({string.Join('/', allowedSigns)})");
    string sign = Console.ReadLine()!;

    //while (!firstSign.Equals(allowedSigns[0], stringComparison) && !firstSign.Equals(allowedSigns[1], stringComparison) && !firstSign.Equals(allowedSigns[2], stringComparison))
    while (!allowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{playerName}, choose correct sign ({string.Join('/', allowedSigns)})");
        sign = Console.ReadLine()!;
    }
    return sign;
}

Console.WriteLine("Let's play Rock-Paper-Scissors");
//const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
//string firstAllowedSign = "rock";
//string secondAllowedSign = "paper";
//string thirdAllowedSign = "scissors";


//Console.WriteLine($"Player 1, choose your sign ({string.Join("/", allowedSigns)})");
//Console.WriteLine($"Player 1, choose your sign ({allowedSigns[0]}/{allowedSigns[1]}/{allowedSigns[2]})");

string firstSign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");

//1. Pobierz indeks znaku podanego przez osobę drugą (np. 0, 1, 2,) - nazwę to index
int secondSignIndex = allowedSigns.IndexOf(secondSign);
//2. Wylicz indeks znaku, który wygrywa z podanym przez osobę drugą - wzór - (secondSignIndex +1) % rozmiarListy
int winningSignIndex = (secondSignIndex + 1) % allowedSigns.Count;
//3. Czy indeks znaku podanego przez pierwszą osobę to indeks wyliczony w punkcie 2.
int firstSignIndex = allowedSigns.IndexOf(firstSign);

//Console.WriteLine($"Player 2, choose your sign ({string.Join('/', allowedSigns)})");
//string secondSign = Console.ReadLine()!;
//(firstSign.Equals(allowedSigns[0], stringComparison) && secondSign.Equals(allowedSigns[2], stringComparison))
//    || (firstSign.Equals(allowedSigns[1], stringComparison) && secondSign.Equals(allowedSigns[0], stringComparison))
//    || (firstSign.Equals(allowedSigns[2], stringComparison) && secondSign.Equals(allowedSigns[1], stringComparison))

if (firstSign.Equals(secondSign, StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("It's a tie!");
}
else if (firstSignIndex == winningSignIndex)
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}