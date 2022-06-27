using Beeline.FileActions;

namespace Beeline.Recorders;

public class FileRecorder : IRecorder
{
    public void Record(ActionResult[] actionResults, string fileFullPath)
    {
        var directory = Path.GetDirectoryName(fileFullPath);
        var fileName = Path.GetFileNameWithoutExtension(fileFullPath);
        Directory.CreateDirectory($"{directory}\\Results");
        foreach (var actionResult in actionResults)
            using (var fileStream = new StreamWriter($"{directory}\\Results\\{fileName}-{actionResult.ActionName}-{actionResult.Result}.txt", false))
                fileStream.Write(actionResult.Result);
    }
}