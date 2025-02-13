List<string> getOnlyUpperWords(List<string> words)
{
    bool isStringUpper = false;
    var results = new List<string>();
    foreach (string word in words)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == char.ToUpper(word[i]) && Char.IsLetter(word[i]))
            {
                isStringUpper = true;
            }
            else
            {
                isStringUpper = false;
                continue;
            }
        }
        if (isStringUpper)
        {
            if (results.Contains(word)) { }
            else
            {
                results.Add(word);
            }
        }

    }
    return results;
}

var words = new List<string> { "Hello", "WORLD", "Hello", "world", "HELLO", "WORLD", "HELLO123" };
var upperWords = getOnlyUpperWords(words);
foreach (var word in upperWords)
{
    Console.WriteLine(word);
}
Console.WriteLine("Press any key to close.");
Console.ReadKey();