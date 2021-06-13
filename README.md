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
|      Simple |   10000 |    212.3 us |   1.30 us |   1.22 us |
|    Parallel |   10000 |    226.0 us |   1.92 us |   1.80 us |
| Multithread |   10000 |  1,028.2 us |   9.79 us |   9.16 us |
|      Simple |  100000 |  2,234.0 us |  12.43 us |  11.62 us |
|    Parallel |  100000 |  1,671.0 us |   8.77 us |   8.20 us |
| Multithread |  100000 |  2,316.6 us |  12.74 us |  11.92 us |
|      Simple | 1000000 | 20,983.8 us | 136.05 us | 120.61 us |
|    Parallel | 1000000 | 13,357.5 us |  19.21 us |  17.03 us |
| Multithread | 1000000 | 15,824.2 us | 113.57 us | 100.68 us |

## MBP 13 i5 2019

BenchmarkDotNet=v0.13.0, OS=macOS Big Sur 11.4 (20F71) [Darwin 20.5.0]
Intel Core i5-8257U CPU 1.40GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.201

- [Host]     : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT
- DefaultJob : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT

|      Method |    size |        Mean |     Error |    StdDev |
|------------ |-------- |------------:|----------:|----------:|
|      Simple |   10000 |    175.2 us |   0.76 us |   0.72 us |
|    Parallel |   10000 |    190.4 us |   3.73 us |   5.23 us |
| Multithread |   10000 |    621.5 us |   2.93 us |   2.45 us |
|      Simple |  100000 |  1,892.7 us |  14.61 us |  13.66 us |
|    Parallel |  100000 |  1,667.0 us |  12.10 us |  11.32 us |
| Multithread |  100000 |  2,138.8 us |  16.26 us |  14.41 us |
|      Simple | 1000000 | 18,190.2 us | 160.97 us | 150.57 us |
|    Parallel | 1000000 | 15,332.3 us | 108.35 us |  96.05 us |
| Multithread | 1000000 | 17,012.6 us | 328.78 us | 307.54 us |

## MBP 13 Mid 2017 (without touch bar)

BenchmarkDotNet=v0.13.0, OS=macOS Catalina 10.15.1 (19B77a) [Darwin 19.0.0]
Intel Core i5-7360U CPU 2.30GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.203
  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  DefaultJob : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT


|      Method |    size |        Mean |     Error |    StdDev |
|------------ |-------- |------------:|----------:|----------:|
|      Simple |   10000 |    164.0 us |   3.19 us |   2.66 us |
|    Parallel |   10000 |    245.4 us |   4.85 us |  11.98 us |
| Multithread |   10000 |    642.2 us |   5.91 us |   5.24 us |
|      Simple |  100000 |  1,728.6 us |   6.40 us |   5.34 us |
|    Parallel |  100000 |  2,269.2 us |  34.43 us |  32.20 us |
| Multithread |  100000 |  3,969.0 us |  41.38 us |  38.71 us |
|      Simple | 1000000 | 18,139.8 us | 149.14 us | 132.21 us |
|    Parallel | 1000000 | 20,803.8 us | 410.20 us | 718.42 us |
| Multithread | 1000000 | 39,365.5 us | 769.70 us | 719.98 us |

# HP Elitebook 14 (840 G7)

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.202
  [Host]     : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET 5.0.5 (5.0.521.16609), X64 RyuJIT


|      Method |    size |        Mean |       Error |      StdDev |
|------------ |-------- |------------:|------------:|------------:|
|      Simple |   10000 |    170.1 us |     3.36 us |     7.10 us |
|    Parallel |   10000 |    183.2 us |     1.77 us |     1.65 us |
| Multithread |   10000 |  1,102.6 us |    15.39 us |    12.85 us |
|      Simple |  100000 |  1,764.7 us |    32.48 us |    25.36 us |
|    Parallel |  100000 |  1,615.3 us |     9.62 us |     8.53 us |
| Multithread |  100000 |  2,617.6 us |    51.92 us |    40.54 us |
|      Simple | 1000000 | 25,584.5 us | 1,454.79 us | 4,266.65 us |
|    Parallel | 1000000 | 15,261.5 us |   285.04 us |   649.18 us |
| Multithread | 1000000 | 17,710.3 us |   352.98 us |   627.42 us |
