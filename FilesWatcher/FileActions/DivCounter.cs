using Beeline.Constants;

namespace Beeline.FileActions;

public class DivCounter : IFileAction
{
    public string ActionName => ActionsNames.DivCount;

    public ActionResult Process(string fileContent)
    {
        var openDivCount = fileContent.ConstainsCount("<div");
        var closeDivCount = fileContent.ConstainsCount("/div");

        return new ActionResult()
        {
            ActionName = ActionName,
            Result = Math.Min(openDivCount, closeDivCount).ToString()
        };
    }
}