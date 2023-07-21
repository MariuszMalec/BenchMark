using BenchmarkDotNet.Running;
using C_BenchMark;

//start benchmark within dotnet
//dotnet run -p C_BenchMark.csproj -c Release
//var results = BenchmarkRunner.Run<FileReadingBenchmark>();
BenchmarkRunner.Run<BenchMarkCollection>();
