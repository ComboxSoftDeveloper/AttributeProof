using System.Runtime.CompilerServices;

namespace AttributeProof;

/// <summary>
/// Все измеряемые способы. У каждого NoInlining: иначе компилятор перенесёт
/// код метода в замер, а вместе с ним туда попадёт и заполнение памяти нулями.
///
/// Атрибут SkipLocalsInit проставлен на отдельных методах, а не на классе:
/// на классе он подействует и на тот вариант, который заполняет память нулями.
/// </summary>
internal static class Subjects
{
    // ---------- отказ от заполнения памяти нулями ----------

    /// <summary>Память на стеке заполняется нулями, как по умолчанию в C#.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int StackWithInit(int size)
    {
        Span<byte> buffer = stackalloc byte[size];

        buffer[0] = 1;
        buffer[^1] = 2;

        return buffer[0] + buffer[^1];
    }

    /// <summary>Та же память, но без заполнения нулями.</summary>
    [SkipLocalsInit]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int StackWithoutInit(int size)
    {
        Span<byte> buffer = stackalloc byte[size];

        buffer[0] = 1;
        buffer[^1] = 2;

        return buffer[0] + buffer[^1];
    }

    // ---------- проверка аргумента ----------

    /// <summary>Проверка из библиотеки: имя аргумента подставит компилятор.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int CheckByLibrary(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        return value.Length;
    }

    /// <summary>Та же проверка, написанная вручную.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int CheckByHand(string value)
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        return value.Length;
    }
}
