namespace Week4;

class Word
{
    private static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    /// <summary>
    /// Count the number of vowels and consonants in a word.
    /// </summary>
    /// <param name="word"></param>
    /// <param name="vowels"></param>
    /// <param name="consonants"></param>
    /// <returns></returns>
    public static bool TryCount(string? word, out int vowels, out int consonants)
    {
        vowels = 0;
        consonants = 0;

        foreach (var ch in word)
        {
            if (!char.IsLetter(ch))
            {
                return false;
            }

            if (Word.vowels.Contains(char.ToLower(ch))) // or use IsVowel(char c)
            {
                vowels++;
            }
            else
            {
                consonants++;
            }
        }
        
        return true;
    }
    
    public static bool IsVowel(char c)
    {
        return vowels.Contains(char.ToLower(c));
    }
}