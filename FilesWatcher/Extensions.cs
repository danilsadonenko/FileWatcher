namespace Beeline;

public static class Extensions
{
    public static int ConstainsCount(this string source, char charToFind)
    {
        return source.ConstainsCount(new[] { charToFind });
    }
    
    public static int ConstainsCount(this string source, string stringToFind)
    {
        return source.ConstainsCount(stringToFind.ToCharArray());
    }
    
    public static int ConstainsCount(this string source, char[] charsToFind)
    {
        if (charsToFind.Length > source.Length)
            return 0;

        var queue = new Queue<char>(source.Substring(0, charsToFind.Length - 1));
        var count = 0;
        for (int i = charsToFind.Length; i < source.Length; i++)
        {
            queue.Enqueue(source[i]);
            
            if (queue.SequenceEqual(charsToFind))
                count++;

            queue.Dequeue();
        }

        return count;
    }

    public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
    {
        if (source is null)
            return true;

        return !source.Any();
    }
}