FizzBuzzDetector detector = new FizzBuzzDetector();

string input = """
Mary had a little lamb

Little lamb, little lamb

Mary had a little lamb

It's fleece was white as snow
""";

detector.getOverlappings(input);

Console.WriteLine("Output:");
Console.WriteLine(detector.Output);

Console.WriteLine("Count: " + detector.Count);