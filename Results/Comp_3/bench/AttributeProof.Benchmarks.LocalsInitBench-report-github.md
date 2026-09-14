```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Size | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----- |-----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| **WithInit**    | **net10** | **net10**     | **64**   |   **2.793 ns** | **0.0293 ns** | **0.0274 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 64   |   2.419 ns | 0.0266 ns | 0.0236 ns |  0.87 |    0.01 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 64   |   2.706 ns | 0.0171 ns | 0.0160 ns |  0.97 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 64   |   2.095 ns | 0.0097 ns | 0.0081 ns |  0.75 |    0.01 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 64   |   2.799 ns | 0.0844 ns | 0.0972 ns |  1.00 |    0.04 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 64   |   2.092 ns | 0.0553 ns | 0.0543 ns |  0.75 |    0.02 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **256**  |   **8.530 ns** | **0.0619 ns** | **0.0548 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 256  |   2.208 ns | 0.0813 ns | 0.0999 ns |  0.26 |    0.01 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 256  |   7.497 ns | 0.1090 ns | 0.1019 ns |  0.88 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 256  |   2.113 ns | 0.0379 ns | 0.0317 ns |  0.25 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 256  |   7.492 ns | 0.1179 ns | 0.1045 ns |  0.88 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 256  |   2.057 ns | 0.0092 ns | 0.0077 ns |  0.24 |    0.00 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **1024** |  **31.281 ns** | **0.1649 ns** | **0.1377 ns** |  **1.00** |    **0.01** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 1024 |   2.574 ns | 0.0799 ns | 0.0952 ns |  0.08 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 1024 |  30.087 ns | 0.0814 ns | 0.0679 ns |  0.96 |    0.00 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 1024 |   2.119 ns | 0.0515 ns | 0.0456 ns |  0.07 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 1024 |  30.109 ns | 0.1082 ns | 0.0904 ns |  0.96 |    0.00 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 1024 |   2.071 ns | 0.0135 ns | 0.0120 ns |  0.07 |    0.00 |     169 B |         - |          NA |
|             |       |           |      |            |           |           |       |         |           |           |             |
| **WithInit**    | **net10** | **net10**     | **4096** | **126.066 ns** | **0.4766 ns** | **0.3980 ns** |  **1.00** |    **0.00** |     **137 B** |         **-** |          **NA** |
| WithoutInit | net10 | net10     | 4096 |   2.685 ns | 0.0096 ns | 0.0085 ns |  0.02 |    0.00 |     162 B |         - |          NA |
| WithInit    | net8  | net8      | 4096 | 123.494 ns | 2.1499 ns | 1.9058 ns |  0.98 |    0.01 |     144 B |         - |          NA |
| WithoutInit | net8  | net8      | 4096 |   2.342 ns | 0.0123 ns | 0.0109 ns |  0.02 |    0.00 |     169 B |         - |          NA |
| WithInit    | net9  | net9      | 4096 | 121.491 ns | 0.5735 ns | 0.4477 ns |  0.96 |    0.00 |     144 B |         - |          NA |
| WithoutInit | net9  | net9      | 4096 |   2.299 ns | 0.0104 ns | 0.0087 ns |  0.02 |    0.00 |     169 B |         - |          NA |
