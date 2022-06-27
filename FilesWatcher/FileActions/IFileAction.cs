namespace Beeline.FileActions;

public interface IFileAction
{
    string ActionName { get; }
    ActionResult Process(string fileContent);
}