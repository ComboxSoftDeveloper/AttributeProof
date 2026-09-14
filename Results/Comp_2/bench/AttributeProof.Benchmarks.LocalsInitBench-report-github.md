```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Size | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| **WithInit**    | **net10** | **net10**     | **64**   |  **2.082 ns** | **0.0203 ns** | **0.0158 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 64   |  4.695 ns | 0.0082 ns | 0.0077 ns |  2.26 |    0.02 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 64   |  2.085 ns | 0.0126 ns | 0.0105 ns |  1.00 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 64   |  4.682 ns | 0.0092 ns | 0.0081 ns |  2.25 |    0.02 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 64   |  2.093 ns | 0.0131 ns | 0.0122 ns |  1.01 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 64   |  4.653 ns | 0.0051 ns | 0.0042 ns |  2.24 |    0.02 |     169 B |         - |          NA |
|             |       |           |      |           |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **256**  |  **5.741 ns** | **0.1559 ns** | **0.2380 ns** |  **1.00** |    **0.06** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 256  |  4.691 ns | 0.0106 ns | 0.0083 ns |  0.82 |    0.04 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 256  |  5.383 ns | 0.0207 ns | 0.0173 ns |  0.94 |    0.04 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 256  |  4.713 ns | 0.0188 ns | 0.0176 ns |  0.82 |    0.04 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 256  |  5.398 ns | 0.0247 ns | 0.0231 ns |  0.94 |    0.04 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 256  |  4.659 ns | 0.0049 ns | 0.0041 ns |  0.81 |    0.04 |     169 B |         - |          NA |
|             |       |           |      |           |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **1024** | **17.712 ns** | **0.1764 ns** | **0.1564 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 1024 |  4.703 ns | 0.0150 ns | 0.0126 ns |  0.27 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 1024 | 17.571 ns | 0.1421 ns | 0.1260 ns |  0.99 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 1024 |  4.749 ns | 0.0745 ns | 0.0942 ns |  0.27 |    0.01 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 1024 | 17.779 ns | 0.1446 ns | 0.1282 ns |  1.00 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 1024 |  4.692 ns | 0.0260 ns | 0.0243 ns |  0.26 |    0.00 |     169 B |         - |          NA |
|             |       |           |      |           |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **4096** | **71.811 ns** | **0.3251 ns** | **0.2714 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 4096 |  4.939 ns | 0.0210 ns | 0.0196 ns |  0.07 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 4096 | 65.864 ns | 0.7195 ns | 0.6730 ns |  0.92 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 4096 |  4.975 ns | 0.0486 ns | 0.0455 ns |  0.07 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 4096 | 71.292 ns | 0.5317 ns | 0.4974 ns |  0.99 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 4096 |  4.927 ns | 0.0177 ns | 0.0166 ns |  0.07 |    0.00 |     169 B |         - |          NA |
