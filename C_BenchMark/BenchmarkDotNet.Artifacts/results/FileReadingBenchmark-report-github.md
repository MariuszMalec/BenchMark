``` ini

BenchmarkDotNet=v0.13.5, OS=ubuntu 22.04
Intel Pentium CPU B960 2.20GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT SSE4.2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT SSE4.2


```
|                Method |      Mean |    Error |   StdDev | Rank |    Gen0 |   Gen1 | Allocated |
|---------------------- |----------:|---------:|---------:|-----:|--------:|-------:|----------:|
| StreamReaderReadBlock |  32.37 μs | 0.117 μs | 0.109 μs |    1 |  9.2163 |      - |   9.46 KB |
|           ReadAllText |  57.25 μs | 0.135 μs | 0.112 μs |    2 | 90.8813 |      - |  93.52 KB |
|          StreamReader | 114.45 μs | 0.475 μs | 0.421 μs |    3 | 65.4297 |      - |  66.88 KB |
|             ReadLines | 123.27 μs | 0.297 μs | 0.263 μs |    4 | 65.4297 |      - |  66.93 KB |
|          ReadAllLines | 132.28 μs | 0.319 μs | 0.266 μs |    5 | 86.4258 | 0.2441 |  88.83 KB |
|          ReadParallel | 236.59 μs | 4.635 μs | 5.862 μs |    6 | 70.8008 |      - |  71.89 KB |
