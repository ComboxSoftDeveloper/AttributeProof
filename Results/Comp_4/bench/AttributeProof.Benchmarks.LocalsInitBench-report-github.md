```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Size | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----- |-----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| **WithInit**    | **net10** | **net10**     | **64**   |   **5.409 ns** | **0.1071 ns** | **0.1001 ns** |  **1.00** |    **0.03** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 64   |   4.512 ns | 0.0487 ns | 0.0455 ns |  0.83 |    0.02 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 64   |   3.616 ns | 0.0922 ns | 0.0947 ns |  0.67 |    0.02 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 64   |   4.516 ns | 0.0467 ns | 0.0414 ns |  0.84 |    0.02 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 64   |   3.424 ns | 0.1076 ns | 0.1361 ns |  0.63 |    0.03 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 64   |   4.584 ns | 0.1034 ns | 0.0967 ns |  0.85 |    0.02 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **256**  |  **13.015 ns** | **0.1455 ns** | **0.1215 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 256  |   4.501 ns | 0.0682 ns | 0.0638 ns |  0.35 |    0.01 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 256  |   8.487 ns | 0.0954 ns | 0.0892 ns |  0.65 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 256  |   4.571 ns | 0.0501 ns | 0.0469 ns |  0.35 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 256  |   8.477 ns | 0.1969 ns | 0.2106 ns |  0.65 |    0.02 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 256  |   4.514 ns | 0.0500 ns | 0.0468 ns |  0.35 |    0.00 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **1024** |  **48.282 ns** | **0.7615 ns** | **0.6751 ns** |  **1.00** |    **0.02** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 1024 |   4.566 ns | 0.1107 ns | 0.1439 ns |  0.09 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 1024 |  26.128 ns | 0.2162 ns | 0.1916 ns |  0.54 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 1024 |   4.504 ns | 0.0569 ns | 0.0532 ns |  0.09 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 1024 |  27.361 ns | 0.4958 ns | 0.4395 ns |  0.57 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 1024 |   4.655 ns | 0.1254 ns | 0.1540 ns |  0.10 |    0.00 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **4096** | **189.264 ns** | **1.1878 ns** | **1.0529 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 4096 |   4.827 ns | 0.0959 ns | 0.0897 ns |  0.03 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 4096 | 106.948 ns | 1.6789 ns | 1.5704 ns |  0.57 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 4096 |   4.819 ns | 0.0779 ns | 0.0728 ns |  0.03 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 4096 | 108.338 ns | 2.2009 ns | 2.1616 ns |  0.57 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 4096 |   4.898 ns | 0.0765 ns | 0.0715 ns |  0.03 |    0.00 |     169 B |         - |          NA |
