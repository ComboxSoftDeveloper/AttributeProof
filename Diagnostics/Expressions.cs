using System.Runtime.CompilerServices;

namespace AttributeProof.Diagnostics;

/// <summary>
/// Исходный текст аргумента. Атрибут CallerArgumentExpression заставляет
/// компилятор подставить в строковый параметр то, что написано в месте вызова.
///
/// Подстановка происходит при сборке, поэтому на выполнении это ничего
/// не стоит: в вызов уходит готовая строковая константа.
/// </summary>
internal static class Expressions
{
    /// <summary>Выводит условие и его значение.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Метод объявлен так:");
        Console.WriteLine();
        Console.WriteLine("  static void Check(bool condition,");
        Console.WriteLine("      [CallerArgumentExpression(nameof(condition))] string? text = null)");
        Console.WriteLine();
        Console.WriteLine("Что попадает в text при разных вызовах:");
        Console.WriteLine();

        const int a = 2;
        const int b = 3;

        string? empty = null;

        Check(a + b > 10);
        Check(a * b == 6);

        Check(empty is null);
        Check(!string.IsNullOrEmpty(empty));

        Console.WriteLine();
        Console.WriteLine("Так устроены проверки из библиотеки классов:");
        Console.WriteLine();

        Describe(() => ArgumentNullException.ThrowIfNull(empty));
        Describe(() => ArgumentOutOfRangeException.ThrowIfNegative(a - 5));

        Console.WriteLine();
        Console.WriteLine("Имя аргумента в исключении взято из места вызова,");
        Console.WriteLine("а не из объявления метода.");

        return 0;
    }

    /// <summary>Одна строка: условие и его значение.</summary>
    private static void Check(bool condition, [CallerArgumentExpression(nameof(condition))] string? text = null)
    {
        Console.WriteLine("  " + (text ?? "").PadRight(38) + (condition ? "истина" : "ложь"));
    }

    /// <summary>Вызывает проверку и выводит имя аргумента из исключения.</summary>
    private static void Describe(Action call)
    {
        try
        {
            call();
            Console.WriteLine("  исключения не было");
        }
        catch (ArgumentException error)
        {
            Console.WriteLine("  " + error.GetType().Name.PadRight(34) + "имя аргумента: " + error.ParamName);
        }
    }
}
