```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method  | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------- |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Library | net10 | net10     | 0.2656 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.03 |      64 B |         - |          NA |
| ByHand  | net10 | net10     | 0.2646 ns | 0.0075 ns | 0.0066 ns |  1.00 |    0.03 |      95 B |         - |          NA |
| Library | net8  | net8      | 0.2564 ns | 0.0033 ns | 0.0029 ns |  0.97 |    0.02 |      63 B |         - |          NA |
| ByHand  | net8  | net8      | 0.2641 ns | 0.0064 ns | 0.0060 ns |  0.99 |    0.03 |      94 B |         - |          NA |
| Library | net9  | net9      | 0.2660 ns | 0.0052 ns | 0.0043 ns |  1.00 |    0.02 |      63 B |         - |          NA |
| ByHand  | net9  | net9      | 0.2789 ns | 0.0075 ns | 0.0066 ns |  1.05 |    0.03 |      94 B |         - |          NA |
