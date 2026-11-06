int [] scores = {75, 43, 90, 91, 80 };

float total = 0, average;

int highestScore = 0;
int lowestScore = 0;

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Score {i + 1}: {scores[i]}");

    total += scores[i];

    if (scores[i] > highestScore)
    {
        highestScore = scores[i];
    }

    if (scores[i] < lowestScore)
    {
        lowestScore = scores[i];
    }
}

average = total / scores.Length;

Console.WriteLine($"Average score: {average}");
Console.WriteLine($"Highest score: {highestScore}");
Console.WriteLine($"Lowest score: {lowestScore}");