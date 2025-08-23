using System.Diagnostics;

var startDate = DateTime.Now;
var process = new Process
{
    StartInfo = new ProcessStartInfo
    {
        FileName = "cmd.exe",
    }
};
process.StartInfo.ArgumentList.Add("/c");
foreach (var arg in args)
{
    process.StartInfo.ArgumentList.Add(arg);
}
process.Start();
process.WaitForExit();
var endDate = DateTime.Now;
Console.WriteLine($"duration: {(endDate - startDate).TotalMilliseconds} ms");