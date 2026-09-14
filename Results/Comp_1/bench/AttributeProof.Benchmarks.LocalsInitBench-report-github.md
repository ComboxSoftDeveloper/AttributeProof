```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Size | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----- |-----------:|----------:|----------:|-----------:|------:|--------:|----------:|----------:|------------:|
| **WithInit**    | **net10** | **net10**     | **64**   |   **2.452 ns** | **0.0744 ns** | **0.2038 ns** |   **2.552 ns** |  **1.01** |    **0.12** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 64   |   1.765 ns | 0.0138 ns | 0.0123 ns |   1.762 ns |  0.72 |    0.06 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 64   |   2.238 ns | 0.0123 ns | 0.0115 ns |   2.238 ns |  0.92 |    0.08 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 64   |   1.822 ns | 0.0117 ns | 0.0098 ns |   1.823 ns |  0.75 |    0.07 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 64   |   2.087 ns | 0.0342 ns | 0.0320 ns |   2.087 ns |  0.86 |    0.08 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 64   |   1.808 ns | 0.0142 ns | 0.0125 ns |   1.807 ns |  0.74 |    0.07 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |            |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **256**  |   **6.475 ns** | **0.0939 ns** | **0.0878 ns** |   **6.468 ns** |  **1.00** |    **0.02** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 256  |   1.729 ns | 0.0137 ns | 0.0128 ns |   1.723 ns |  0.27 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 256  |   6.266 ns | 0.0261 ns | 0.0244 ns |   6.275 ns |  0.97 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 256  |   1.756 ns | 0.0146 ns | 0.0137 ns |   1.753 ns |  0.27 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 256  |   6.303 ns | 0.0337 ns | 0.0315 ns |   6.300 ns |  0.97 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 256  |   1.759 ns | 0.0106 ns | 0.0094 ns |   1.762 ns |  0.27 |    0.00 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |            |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **1024** |  **25.505 ns** | **0.0990 ns** | **0.0827 ns** |  **25.508 ns** |  **1.00** |    **0.00** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 1024 |   1.769 ns | 0.0159 ns | 0.0149 ns |   1.769 ns |  0.07 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 1024 |  25.734 ns | 0.1570 ns | 0.1468 ns |  25.710 ns |  1.01 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 1024 |   1.785 ns | 0.0120 ns | 0.0107 ns |   1.784 ns |  0.07 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 1024 |  25.764 ns | 0.2994 ns | 0.2800 ns |  25.643 ns |  1.01 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 1024 |   1.745 ns | 0.0337 ns | 0.0315 ns |   1.749 ns |  0.07 |    0.00 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |            |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **4096** | **103.474 ns** | **0.4732 ns** | **0.4426 ns** | **103.586 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 4096 |   2.043 ns | 0.0313 ns | 0.0261 ns |   2.047 ns |  0.02 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 4096 | 106.534 ns | 0.5005 ns | 0.4437 ns | 106.444 ns |  1.03 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 4096 |   2.105 ns | 0.0449 ns | 0.0420 ns |   2.090 ns |  0.02 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 4096 | 104.619 ns | 1.4825 ns | 1.3867 ns | 104.543 ns |  1.01 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 4096 |   2.094 ns | 0.0298 ns | 0.0279 ns |   2.089 ns |  0.02 |    0.00 |     169 B |         - |          NA |
