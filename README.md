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


|      Method |    size |        Mean |     Error |    StdDev |      Median |
|------------ |-------- |------------:|----------:|----------:|------------:|
|      Simple |   10000 |    242.2 us |   4.75 us |   6.01 us |    239.6 us |
|    Parallel |   10000 |    201.1 us |   3.52 us |   3.12 us |    200.3 us |
| Multithread |   10000 |  1,230.1 us |  10.94 us |   9.69 us |  1,229.0 us |
|      Simple |  100000 |  1,926.5 us |  64.15 us | 187.12 us |  1,807.4 us |
|    Parallel |  100000 |  1,565.3 us |   6.87 us |   5.73 us |  1,566.0 us |
| Multithread |  100000 |  2,819.3 us |  54.52 us |  58.33 us |  2,793.8 us |
|      Simple | 1000000 | 18,172.6 us |  83.17 us |  69.45 us | 18,167.2 us |
|    Parallel | 1000000 | 15,270.2 us | 302.45 us | 252.56 us | 15,201.7 us |
| Multithread | 1000000 | 19,428.5 us | 382.75 us | 798.95 us | 19,370.8 us |
