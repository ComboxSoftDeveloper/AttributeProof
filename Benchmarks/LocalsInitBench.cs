using BenchmarkDotNet.Attributes;
using AttributeProof.Types;

namespace AttributeProof.Benchmarks;

/// <summary>
/// Раздел 3. Отказ от заполнения памяти нулями. Один и тот же метод
/// с атрибутом SkipLocalsInit и без него, на четырёх размерах буфера.
///
/// Атрибут проставлен на методе, а не на классе: на классе он подействует
/// и на тот вариант, который заполняет память нулями.
/// </summary>
public class LocalsInitBench
{
    /// <summary>Размер буфера в байтах.</summary>
    [ParamsSource(nameof(SizeValues))]
    public int Size { get; set; }

    /// <summary>Размеры общие с отчётами.</summary>
    public static IEnumerable<int> SizeValues => Payloads.Sizes;

    /// <summary>Память заполняется нулями, как по умолчанию в C#.</summary>
    [Benchmark(Baseline = true)]
    public int WithInit() => Subjects.StackWithInit(Size);

    /// <summary>Та же память без заполнения нулями.</summary>
    [Benchmark]
    public int WithoutInit() => Subjects.StackWithoutInit(Size);
}
