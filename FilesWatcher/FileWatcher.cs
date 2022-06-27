using Beeline.FileHandler;
using Beeline.Recorders;

namespace Beeline;

public class FileWatcher : IDisposable
{
    private FileSystemWatcher _watcher;
    private IRecorder _recorder;

    public FileWatcher(string path, IRecorder recorder)
    {
        _watcher = new FileSystemWatcher(path);
        _recorder = recorder;
        _watcher.NotifyFilter = NotifyFilters.FileName;
        _watcher.EnableRaisingEvents = true;
        _watcher.Created += OnCreated;
    }

    private void OnCreated(object sender, FileSystemEventArgs e)
    {
        var fileExtension = Path.GetExtension(e.FullPath);
        var file = FileReader.GetFileAsString(e.FullPath);
        var result = FileHandlerFactory.GetHandler(fileExtension).Process(file);
        _recorder.Record(result.ToArray(), e.FullPath);
    }

    public void Dispose()
    {
        _watcher.Dispose();
    }
}