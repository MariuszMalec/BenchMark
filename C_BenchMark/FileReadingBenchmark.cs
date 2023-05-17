using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
//[SimpleJob(launchCount: 1, warmupCount: 1)]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class FileReadingBenchmark
{
    // Set the path to the file you want to read
    private string filePath = @"/home/mario/repo/P_PythonEducation/Source/1406149.SPF";

    // Add a benchmark method for each method you want to test
    [Benchmark]
    public void ReadAllText()
    {
        string fileContents = File.ReadAllText(filePath);
    }

    [Benchmark]
    public void ReadAllLines()
    {
        string[] lines = File.ReadAllLines(filePath);
    }

    [Benchmark]
    public void StreamReader()
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                //
            }
        }
    }

    [Benchmark]
    public void StreamReaderReadBlock()
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            char[] buffer = new char[1024];
            int numRead;
            while ((numRead = reader.ReadBlock(buffer, 0, buffer.Length)) > 0)
            {
                // Do something with the chunk of characters
            }
        }
    }

    [Benchmark]
    public void ReadLines()
    {
        foreach (string line in File.ReadLines(filePath))
        {
            //
        }
    }

    [Benchmark]
    public void ReadParallel()
    {
        Parallel.ForEach(
            File.ReadLines(filePath), //returns IEumberable<string>: lazy-loading
            new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
            (line, state, index) =>
            {
                //              
            }
        );
    }
}