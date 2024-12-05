using System.IO.Abstractions;

namespace Testable.Abstractions.MemoryStream;

public interface IMemoryStreamWrapper
{
    void CopyStream(System.IO.MemoryStream memoryStream, FileSystemStream fileStream);
}
