using MKR_1;

var input = FileReaderUtil.Read(FileReaderUtil.RPATH);

var N = 0;
try
{
    N = int.Parse(input[0]);
}
catch (Exception e)
{
    FileReaderUtil.Write(FileReaderUtil.WPATH, "text from file should be integer number");
    return;
}


if (N <= 1)
{
    FileReaderUtil.Write(FileReaderUtil.WPATH, "N should be > 1");
    return;
}

var task = new LuckyNumbersTask();
var result = task.Handle(N);
Console.WriteLine($"{result}");

FileReaderUtil.Write(FileReaderUtil.WPATH, result);