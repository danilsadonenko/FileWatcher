using Beeline.Constants;

namespace Beeline.FileHandler;

public static class FileHandlerFactory
{
    public static FileHandlerBase GetHandler(string fileExtension)
    {
        return fileExtension switch
        {
            FilesExtensions.HTML => new HtmlHandler(),
            FilesExtensions.CSS => new CssHandler(),
            _ => new UnidentifiedFileHandler()
        };
    }
}