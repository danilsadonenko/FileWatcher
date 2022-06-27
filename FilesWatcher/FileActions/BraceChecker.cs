using Beeline.Constants;

namespace Beeline.FileActions;

public class BraceChecker : IFileAction
{
    public string ActionName => ActionsNames.BraceCheck;

    public ActionResult Process(string fileContent)
    {
        var openBraceCount = fileContent.ConstainsCount('{');
        var closeBraceCount = fileContent.ConstainsCount('}');

        return new ActionResult()
        {
            ActionName = ActionName,
            Result = (openBraceCount == closeBraceCount).ToString()
        };
    }
}