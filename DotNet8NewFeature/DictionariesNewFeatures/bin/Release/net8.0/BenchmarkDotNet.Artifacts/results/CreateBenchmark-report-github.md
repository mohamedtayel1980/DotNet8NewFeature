```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.4355/22H2/2022Update)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method                    | Mean       | Error     | StdDev    | Median     | Ratio  | RatioSD |
|-------------------------- |-----------:|----------:|----------:|-----------:|-------:|--------:|
| CreateList                |   2.191 ms | 0.1307 ms | 0.3832 ms |   2.046 ms |   1.00 |    0.00 |
| CreateDictionary          |   9.615 ms | 0.1921 ms | 0.1887 ms |   9.623 ms |   5.09 |    0.20 |
| CreateImmutableDictionary | 349.485 ms | 6.9285 ms | 6.1420 ms | 348.612 ms | 184.25 |    8.88 |
| CreateFrozenSet           |  22.203 ms | 0.4353 ms | 0.5661 ms |  22.151 ms |  11.72 |    0.58 |
| CreateFrozenDictionary    |  30.651 ms | 0.6074 ms | 1.1107 ms |  30.737 ms |  14.81 |    2.41 |
