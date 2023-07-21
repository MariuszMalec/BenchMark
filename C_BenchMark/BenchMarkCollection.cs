using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace C_BenchMark
{
    //[SimpleJob(RuntimeMoniker.Net60, baseline:true)]//nie dziala jak dodam do csproj ;net6.0!!???
    //[SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser]
    public class BenchMarkCollection
    {
        private List<int> _collection = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Add a benchmark method for each method you want to test

        [Benchmark(Baseline = true)]
        public void ForTest()
        {
            for (int i = 0; i < _collection.Count(); i++) { }
        }

        [Benchmark]
        public void ForeachTest()
        {
            foreach (var item in _collection) { }
        }

    }
}
