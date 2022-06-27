using Beeline.Constants;

namespace Beeline.FileActions;

public class PunctuationMarksCounter : IFileAction
{
    public string ActionName => ActionsNames.PunctuationMarksCounter;
    public ActionResult Process(string fileContent)
    {
        return new ActionResult()
        {
            ActionName = ActionName,
            Result = fileContent.Count(x => Char.IsPunctuation(x)).ToString()
        };
    }
}