using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Running;

//start benchmark
//dotnet run -p C_BenchMark.csproj -c Release
var results = BenchmarkRunner.Run<FileReadingBenchmark>();

//TESTS
//string textFile = @"/home/mario/repo/P_PythonEducation/Source/B011382_33N.SPF";
//Stopwatch watch = new Stopwatch();
// watch.Start();
//    if (File.Exists(textFile)) {
//     // Read entire text file content in one string
//     string text = File.ReadAllText(textFile);
//     Console.WriteLine(text);
//    }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());
   
// watch = new Stopwatch();
// watch.Start();
//    if (File.Exists(textFile)) {
//     // Read a text file line by line.
//     string[] lines = File.ReadAllLines(textFile);
//     foreach(string line in lines)
//     {
//         Console.WriteLine(line);
//     }
//    }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
//    if (File.Exists(textFile)) {
//     // Read file using StreamReader. Reads file line by line
//     using(StreamReader file = new StreamReader(textFile)) {
//      int counter = 0;
//      string ln;

//      while ((ln = file.ReadLine()) != null) {
//       Console.WriteLine(ln);
//       counter++;
//      }
//      file.Close();
//     }
//    }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
// var lines = File.ReadLines(textFile);
// foreach (var line in lines)
//   Console.WriteLine(line);
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
// using (StreamReader sr = File.OpenText(textFile))
// {
//         string s = String.Empty;
//         while ((s = sr.ReadLine()) != null)
//         {
//             Console.WriteLine(s);
//         }
// }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
// foreach (string line in File.ReadAllLines(textFile))
// {
//     Console.WriteLine(line);
// }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
// using (FileStream fs = File.Open(textFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
// using (BufferedStream bs = new BufferedStream(fs))
// using (StreamReader sr = new StreamReader(bs))
// {
//     string line;
//     while ((line = sr.ReadLine()) != null)
//     {
//         Console.WriteLine(line);
//     }
// }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
// using (StreamReader sr = new StreamReader(textFile))
// {
//     string line = string.Empty;
//     while ((line = sr.ReadLine()) != null)
//     {
//         Console.WriteLine(line);
//     }
// }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
// Parallel.ForEach(
//     File.ReadLines(textFile), //returns IEumberable<string>: lazy-loading
//     new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
//     (line, state, index) =>
//     {
//         Console.WriteLine(line);
//     }
// );
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

// watch = new Stopwatch();
// watch.Start();
// using (StreamReader sr = File.OpenText(textFile))
// {
//     string s = String.Empty;
//     while ((s = sr.ReadLine()) != null)
//     {
//         Console.WriteLine(s);
//     }
// }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());

//narzazie najszybciej!
// watch = new Stopwatch();//10.16
// watch.Start();
// using (StreamReader reader = new StreamReader(textFile))
// {
//     char[] buffer = new char[1024];//1024
//     int numRead;
//     while ((numRead = reader.ReadBlock(buffer, 0, buffer.Length)) > 0)
//     {
//         Console.WriteLine(buffer);
//     }
// }
// watch.Stop();
// Console.WriteLine(watch.Elapsed.TotalSeconds.ToString());