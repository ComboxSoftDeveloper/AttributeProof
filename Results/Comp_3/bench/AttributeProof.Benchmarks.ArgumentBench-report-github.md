```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method  | Job   | Toolchain | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------- |------ |---------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Library | net10 | net10     | 0.7058 ns | 0.0048 ns | 0.0040 ns | 0.7053 ns |  1.00 |    0.01 |      64 B |         - |          NA |
| ByHand  | net10 | net10     | 0.6427 ns | 0.0648 ns | 0.1900 ns | 0.5756 ns |  0.91 |    0.27 |      95 B |         - |          NA |
| Library | net8  | net8      | 0.4621 ns | 0.0109 ns | 0.0097 ns | 0.4598 ns |  0.65 |    0.01 |      63 B |         - |          NA |
| ByHand  | net8  | net8      | 0.4781 ns | 0.0122 ns | 0.0108 ns | 0.4769 ns |  0.68 |    0.02 |      94 B |         - |          NA |
| Library | net9  | net9      | 0.7314 ns | 0.0317 ns | 0.0265 ns | 0.7204 ns |  1.04 |    0.04 |      63 B |         - |          NA |
| ByHand  | net9  | net9      | 0.4878 ns | 0.0137 ns | 0.0122 ns | 0.4835 ns |  0.69 |    0.02 |      94 B |         - |          NA |
