
Console.WriteLine("IELTS score average FOR academic");

Console.Write("Listening score: ");
string listeningScoreInput = Console.ReadLine()!;

Console.Write("Reading score: ");
string readingScoreInput = Console.ReadLine()!;

System.Console.Write("Speaking score: ");
string speakingScoreInput = Console.ReadLine()!;

Console.Write("Writing score: ");






string writingScoreInput = Console.ReadLine()!;
decimal[] scores={
    Convert.ToDecimal(readingScoreInput),
    Convert.ToDecimal(listeningScoreInput),
    Convert.ToDecimal(writingScoreInput),
    Convert.ToDecimal(speakingScoreInput)
    };
decimal averageScore = scores.Average();
int scoreInteger = (int)averageScore;
decimal remainder = averageScore-scoreInteger;

decimal scoreRemainder = remainder switch 
{
   _ when remainder < 0.25m => 0,
   _ when remainder < 0.75m && remainder >= 0.25m => 0.5m,
   _ => 1, 
};
averageScore=scoreInteger+scoreRemainder;
Console.WriteLine($"Avreage score: {averageScore}");

