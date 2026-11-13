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
    }

    private bool IsAlphanumeric(char c)
    {
        return (c >= 'a' && c <= 'z') ||
               (c >= 'A' && c <= 'Z') ||
               (c >= '0' && c <= '9');
    }
}