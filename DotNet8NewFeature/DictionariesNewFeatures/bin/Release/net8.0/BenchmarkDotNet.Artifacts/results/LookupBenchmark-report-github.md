```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.4355/22H2/2022Update)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method                    | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD |
|-------------------------- |----------:|----------:|----------:|----------:|------:|--------:|
| LookupList                | 50.080 μs | 0.8246 μs | 1.1008 μs | 49.592 μs |  1.00 |    0.00 |
| LookupDictionary          |  4.094 μs | 0.0622 μs | 0.0551 μs |  4.077 μs |  0.08 |    0.00 |
| LookupImmutableDictionary | 46.478 μs | 0.9173 μs | 2.1801 μs | 45.361 μs |  0.94 |    0.04 |
| LookupFrozenSet           |  1.958 μs | 0.0376 μs | 0.0402 μs |  1.947 μs |  0.04 |    0.00 |
| LookupFrozenDictionary    |  2.739 μs | 0.0407 μs | 0.0318 μs |  2.741 μs |  0.05 |    0.00 |
