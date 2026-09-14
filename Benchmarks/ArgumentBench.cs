using BenchmarkDotNet.Attributes;

namespace AttributeProof.Benchmarks;

/// <summary>
/// Раздел 2. Библиотечная проверка аргумента и такая же, написанная явно.
/// Имя аргумента подставляет компилятор при сборке, поэтому разницы быть
/// не должно — замер это и проверяет.
///
/// На вход всегда передаётся непустая строка, поэтому проверка на null
/// ни разу не срабатывает.
/// </summary>
public class ArgumentBench
{
    private const string Value = "значение";

    /// <summary>Проверка из библиотеки.</summary>
    [Benchmark(Baseline = true)]
    public int Library() => Subjects.CheckByLibrary(Value);

    /// <summary>Такая же проверка, написанная явно.</summary>
    [Benchmark]
    public int ByHand() => Subjects.CheckByHand(Value);
}
