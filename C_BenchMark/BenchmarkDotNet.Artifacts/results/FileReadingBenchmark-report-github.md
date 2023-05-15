``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
Intel Pentium CPU B960 2.20GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT SSE4.2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT SSE4.2


```
|       Method |      Mean |    Error |   StdDev |    Median | Rank |    Gen0 |   Gen1 | Allocated |
|------------- |----------:|---------:|---------:|----------:|-----:|--------:|-------:|----------:|
|  ReadAllText |  59.00 μs | 0.341 μs | 0.302 μs |  58.85 μs |    1 | 90.8203 |      - |  93.52 KB |
| StreamReader | 115.38 μs | 0.488 μs | 0.432 μs | 115.27 μs |    2 | 65.4297 |      - |  66.88 KB |
|    ReadLines | 126.63 μs | 2.474 μs | 3.703 μs | 124.68 μs |    3 | 65.4297 |      - |  66.93 KB |
| ReadAllLines | 136.37 μs | 1.746 μs | 1.793 μs | 135.74 μs |    4 | 86.4258 | 0.2441 |  88.83 KB |
