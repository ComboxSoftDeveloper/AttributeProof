```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method  | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------- |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Library | net10 | net10     | 0.6679 ns | 0.0217 ns | 0.0169 ns |  1.00 |    0.03 |      59 B |         - |          NA |
| ByHand  | net10 | net10     | 0.7231 ns | 0.0320 ns | 0.0299 ns |  1.08 |    0.05 |      90 B |         - |          NA |
| Library | net8  | net8      | 0.6853 ns | 0.0268 ns | 0.0224 ns |  1.03 |    0.04 |      58 B |         - |          NA |
| ByHand  | net8  | net8      | 1.0704 ns | 0.0510 ns | 0.0501 ns |  1.60 |    0.08 |      89 B |         - |          NA |
| Library | net9  | net9      | 0.7266 ns | 0.0377 ns | 0.0315 ns |  1.09 |    0.05 |      58 B |         - |          NA |
| ByHand  | net9  | net9      | 0.6463 ns | 0.0206 ns | 0.0193 ns |  0.97 |    0.04 |      89 B |         - |          NA |
