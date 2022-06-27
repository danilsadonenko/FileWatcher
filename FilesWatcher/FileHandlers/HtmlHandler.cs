using Beeline.FileActions;

namespace Beeline.FileHandler;

public class HtmlHandler : FileHandlerBase
{
    private protected override IFileAction[] _availableActions => new[]
    {
        new DivCounter()
    };
}