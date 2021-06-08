# thread-calculation

## How to run

`dotnet run -c Release`

## Legends

- size   : Value of the 'size' parameter
- Mean   : Arithmetic mean of all measurements
- Error  : Half of 99.9% confidence interval
- StdDev : Standard deviation of all measurements
- 1 us   : 1 Microsecond (0.000001 sec)

## MBP 13 M1

BenchmarkDotNet=v0.13.0, OS=macOS Big Sur 11.4 (20F71) [Darwin 20.5.0]
Apple M1 2.40GHz, 1 CPU, 8 logical and 8 physical cores
.NET SDK=5.0.300

- [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
- DefaultJob : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT

|      Method |    size |        Mean |     Error |    StdDev |
|------------ |-------- |------------:|----------:|----------:|
|      Simple |   10000 |    224.0 us |   1.26 us |   1.18 us |
|    Parallel |   10000 |    349.9 us |   1.48 us |   1.39 us |
| Multithread |   10000 |  1,227.5 us |   5.59 us |   4.95 us |
|      Simple |  100000 |  1,993.4 us |   9.85 us |   9.22 us |
|    Parallel |  100000 |  2,679.3 us |  24.74 us |  23.14 us |
| Multithread |  100000 |  4,390.3 us |   7.57 us |   7.08 us |
|      Simple | 1000000 | 17,923.0 us |  30.13 us |  28.19 us |
|    Parallel | 1000000 | 25,092.2 us |  93.11 us |  87.09 us |
| Multithread | 1000000 | 46,259.4 us | 840.53 us | 825.52 us |

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
