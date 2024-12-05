using System.IO.Abstractions;

namespace Testable.Abstractions.MemoryStream;

public class MemoryStreamWrapper : IMemoryStreamWrapper
{
    public void CopyStream(System.IO.MemoryStream memoryStream, FileSystemStream fileStream)
    {
        memoryStream.WriteTo(fileStream);
    }
}
