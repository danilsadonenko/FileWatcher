using Beeline.FileActions;

namespace Beeline.FileHandler;

public class CssHandler : FileHandlerBase
{
    private protected override IFileAction[] _availableActions => new[]
    {
        new BraceChecker()
    };
}