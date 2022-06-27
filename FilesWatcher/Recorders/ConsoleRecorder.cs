using System.Threading.Channels;
using Beeline.FileActions;

namespace Beeline.Recorders;

public class ConsoleRecorder : IRecorder
{
    public void Record(ActionResult[] actionResults, string fileFullPath)
    {
        var fileName = Path.GetFileNameWithoutExtension(fileFullPath);
        foreach (var actionResult in actionResults)
        {
            Console.WriteLine($"{fileName} {actionResult.ActionName} {actionResult.Result}");
        }
    }
}