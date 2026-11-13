public class FizzBuzzDetector
{
    public string Output { get; set; } = "";
    public int Count { get; set; }


    public FizzBuzzDetector getOverlappings(string input)
    {
        List<string> words = new();

        int i = 0;

        while (i < input.Length)
        {
            string element = "";

            if (IsAlphanumeric(input[i]))
            {
                while (i < input.Length && IsAlphanumeric(input[i]))
                {
                    element += input[i];
                    i++;
                }
            }
            else
            {
                element += input[i];
                i++;
            }

            words.Add(element);
        }

        int wordCount = 0;
        int count = 0;

        for (int j = 0; j < words.Count; j++)
        {
            if (!IsAlphanumeric(words[j][0]))
                continue;

            wordCount++;

            if (wordCount % 15 == 0)
                words[j] = "FizzBuzz";
            else if (wordCount % 3 == 0)
                words[j] = "Fizz";
            else if (wordCount % 5 == 0)
                words[j] = "Buzz";
            else
                continue;

            count++;
        }

        return new FizzBuzzDetector
        {
            Output = string.Join("", words),
            Count = count
        };
    }

    private bool IsAlphanumeric(char c)
    {
        return (c >= 'a' && c <= 'z') ||
               (c >= 'A' && c <= 'Z') ||
               (c >= '0' && c <= '9');
    }
}