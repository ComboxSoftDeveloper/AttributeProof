using System.Text;
using BenchmarkDotNet.Running;
using AttributeProof.Benchmarks;
using AttributeProof.Diagnostics;
using AttributeProof.Types;

namespace AttributeProof;

/// <summary>
/// Точка входа. Без аргументов запускаются замеры, с именем отчёта — отчёт.
/// </summary>
internal static class Program
{
    /// <summary>Разбор аргументов и запуск.</summary>
    private static int Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Startup.Order.Add("точка входа");

        string mode = args.Length > 0 ? args[0] : string.Empty;
        return mode switch
        {
            "checks" => Checks.Run(),
            "startup" => StartupReport.Run(),
            "expression" => Expressions.Run(),
            _ => Bench(args),
        };
    }

    /// <summary>Запуск замеров. Аргумент noasm выключает снятие машинного кода.</summary>
    private static int Bench(string[] args)
    {
        bool disassembly = !args.Contains("noasm");
        string[] rest = args.Where(argument => argument != "noasm").ToArray();

        BenchmarkSwitcher
            .FromTypes([typeof(LocalsInitBench), typeof(ArgumentBench)])
            .Run(rest, new BenchmarkConfig(disassembly));

        return 0;
    }
}
