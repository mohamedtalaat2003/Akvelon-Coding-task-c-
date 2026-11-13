using Akvelon_Coding_task_c_;
FizzBuzzDetector detector = new FizzBuzzDetector();

string input = """
Mary had a little lamb

Little lamb, little lamb

Mary had a little lamb

It's fleece was white as snow
""";

FizzBuzzResult result = detector.getOverlappings(input);

Console.WriteLine("Output:");
Console.WriteLine(result.Output);

Console.WriteLine("Count: " + result.Count);