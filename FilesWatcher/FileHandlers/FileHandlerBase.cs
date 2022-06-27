using Beeline.FileActions;

namespace Beeline.FileHandler;

public abstract class FileHandlerBase
{
    private protected abstract IFileAction[] _availableActions { get; }

    public virtual IEnumerable<ActionResult> Process(string fileContent)
    {
        foreach (var action in _availableActions)
            yield return action.Process(fileContent);
    }
}