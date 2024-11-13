namespace MKR_1;

public class FileReaderUtil
{
    
    public static readonly string RPATH = Path.Combine(Path.GetFullPath("Files"), "INPUT.txt");
    public static readonly string WPATH = Path.Combine(Path.GetFullPath("Files"), "OUTPUT.txt");
    
    
    public static string[] Read(string inputFilePath)
    {
        return File.ReadAllLines(inputFilePath);
    }
    
    public static void Write(string outputFilePath, object output)
    {
        File.WriteAllText(outputFilePath, output.ToString());
    }
    
}