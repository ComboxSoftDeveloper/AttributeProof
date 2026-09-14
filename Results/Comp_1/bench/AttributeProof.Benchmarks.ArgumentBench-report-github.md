```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method  | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------- |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Library | net10 | net10     | 0.3944 ns | 0.0051 ns | 0.0046 ns |  1.00 |    0.02 |      64 B |         - |          NA |
| ByHand  | net10 | net10     | 0.3969 ns | 0.0046 ns | 0.0036 ns |  1.01 |    0.01 |      95 B |         - |          NA |
| Library | net8  | net8      | 0.4080 ns | 0.0202 ns | 0.0188 ns |  1.03 |    0.05 |      63 B |         - |          NA |
| ByHand  | net8  | net8      | 0.4022 ns | 0.0152 ns | 0.0142 ns |  1.02 |    0.04 |      94 B |         - |          NA |
| Library | net9  | net9      | 0.4167 ns | 0.0217 ns | 0.0203 ns |  1.06 |    0.05 |      63 B |         - |          NA |
| ByHand  | net9  | net9      | 0.4232 ns | 0.0315 ns | 0.0246 ns |  1.07 |    0.06 |      94 B |         - |          NA |
