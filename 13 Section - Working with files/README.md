# 13 Section - Working with files

    - In this section we recap how to work with files in C#;

### File, FileInfo

    • System.IO namespace;
    • Performs operations with files (create, copy, delete, move, open, etc.) and helps in creating FileStream objects;
    • File:
      • static members (simple, but performs security check for each operation);
      • https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx;
    • FileInfo:
      • instancemembers;
      • https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx;

### IOException

    - Namespace System.IO;
    • IOException:
      • DirectoryNotFoundException;
      • DriveNotFoundException;
      • EndOfStreamException;
      • FileLoadException;
      • FileNotFoundException;
      • PathTooLongException;
      • PipeException;

### FileStream

    - https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.90).aspx
    - Provides a stream associated with a file, allowing reading and writing operations;
    - Binary data support;
    - Instantiation:
      • Various constructors;
      • File/FileInfo;

<p align="center">
  <img src="./screenshots/filestream.png" width="350" title="Console">
</p>

### StreamReader

    - https://msdn.microsoft.com/en-us/library/system.io.streamreader(v=vs.90).aspx
    - It is a stream capable of reading characters from a binary stream (ex: FileStream);
    - Support data in text format;
    - Instantiation:
      • Various constructors;
      • File/FileInfo;

<p align="center">
  <img src="./screenshots/streamreader.png" width="350" title="Console">
</p>

### using block

    - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
    - Simplified syntax that guarantees that IDisposable objects will be closed;
    - IDisposable objects are NOT managed by the CLR. They need to be manually closed;
      • Examples: Font, FileStream, StreamReader, StreamWriter;

### StreamWriter

    - https://msdn.microsoft.com/en-us/library/system.io.streamwriter(v=vs.110).aspx
    - It is a stream capable of writing characters from a binary stream (ex: FileStream);
    - Support for data in text format;
    - Instantiation:
      • Various constructors;
      • File/FileInfo;
        • CreateText(path);
        • AppendText(String);

<p align="center">
  <img src="./screenshots/streamwriter.png" width="350" title="Console">
</p>

### Directory, DirectoryInfo

    • Namespace System.IO;
    • Operations with folders (create, enumerate, get files, etc.);
    • Directory:
      • static members (simple, but performs security check for each operation);
      • https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
    • DirectoryInfo:
      • instancemembers;
      • https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx

### Path

    • Namespace System.IO;
    • Performs operations with strings that contain file informatio or folders;
    • https://msdn.microsoft.com/en-us/library/system.io.path(v=vs.110).aspx
