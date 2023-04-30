using System.IO;

namespace FileTest;

public static class File {
    public static void Run(){
        var text = "Hello C# course";
        var streamWriter = new StreamWriter("./file.txt", true);
        streamWriter.WriteLine(text);
        streamWriter.Close();

        var streamReader = new StreamReader("./file.txt");
        var readText = streamReader.ReadToEnd();
        streamReader.Close();
        Console.WriteLine(readText);
    }
}
