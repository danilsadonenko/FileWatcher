using System.Text;

namespace Beeline;

public class FileReader
{
    public static string GetFileAsString(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException();
        
        using (FileStream fileStream = File.OpenRead(filePath))
        {
            byte[] buffer = new byte[fileStream.Length];
            fileStream.ReadAsync(buffer, 0, buffer.Length).Wait();
            return Encoding.Default.GetString(buffer);
        }
    }
}