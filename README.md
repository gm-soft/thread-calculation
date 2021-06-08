# thread-calculation

## MBP 13 M1

|      Method |    size |        Mean |     Error |    StdDev |
|------------ |-------- |------------:|----------:|----------:|
|      Simple |   10000 |    174.1 us |   0.97 us |   0.81 us |
|    Parallel |   10000 |    347.3 us |   2.70 us |   2.39 us |
| Multithread |   10000 |  1,269.9 us |  25.26 us |  28.08 us |
|      Simple |  100000 |  2,017.2 us |  13.19 us |  11.02 us |
|    Parallel |  100000 |  2,538.8 us |  23.60 us |  22.07 us |
| Multithread |  100000 |  5,163.5 us |  14.72 us |  13.05 us |
|      Simple | 1000000 | 18,018.0 us |  22.06 us |  20.63 us |
|    Parallel | 1000000 | 19,839.1 us | 109.00 us | 101.96 us |
| Multithread | 1000000 | 37,024.5 us | 385.58 us | 360.68 us |

## MBP 13 i5 2019

BenchmarkDotNet=v0.13.0, OS=macOS Big Sur 11.4 (20F71) [Darwin 20.5.0]
Intel Core i5-8257U CPU 1.40GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.201

- [Host]     : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT
- DefaultJob : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT

|      Method |    size |        Mean |     Error |    StdDev |
|------------ |-------- |------------:|----------:|----------:|
|      Simple |   10000 |    173.6 us |   1.21 us |   1.07 us |
|    Parallel |   10000 |    338.2 us |   6.73 us |  19.51 us |
| Multithread |   10000 |    824.1 us |   3.23 us |   2.86 us |
|      Simple |  100000 |  1,815.2 us |  12.83 us |  12.00 us |
|    Parallel |  100000 |  2,306.2 us |  10.20 us |   9.54 us |
| Multithread |  100000 |  4,356.6 us |  20.17 us |  17.88 us |
|      Simple | 1000000 | 17,872.2 us |  51.68 us |  45.81 us |
|    Parallel | 1000000 | 20,525.2 us | 285.38 us | 252.98 us |
| Multithread | 1000000 | 38,215.0 us | 659.93 us | 759.97 us |
