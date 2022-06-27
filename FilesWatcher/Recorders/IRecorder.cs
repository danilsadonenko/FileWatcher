using Beeline.FileActions;

namespace Beeline.Recorders;

public interface IRecorder
{
    void Record(ActionResult[] actionResults, string fileFullPath);
}