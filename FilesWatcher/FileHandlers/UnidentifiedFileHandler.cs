using Beeline.FileActions;

namespace Beeline.FileHandler;

public class UnidentifiedFileHandler : FileHandlerBase
{
    private protected override IFileAction[] _availableActions => new[]
    {
        new PunctuationMarksCounter()
    };
}