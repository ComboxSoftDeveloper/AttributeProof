using System.Runtime.CompilerServices;
using AttributeProof.Types;

namespace AttributeProof.Diagnostics;

/// <summary>
/// Сверка. Проверяет каждое утверждение статьи на том рантайме, где запущена.
/// Если поведение изменится, прогон это заметит и вернёт код 1.
/// </summary>
internal static class Checks
{
    /// <summary>Код возврата: 0 — всё сошлось, 1 — есть расхождение.</summary>
    internal static int Run()
    {
        bool ok = true;

        ok &= InitializerRanFirst();
        ok &= ExpressionIsText();
        ok &= StackResultsAgree();

        Console.WriteLine();
        Console.WriteLine(ok ? "СВЕРКА ПРОЙДЕНА" : "СВЕРКА НЕ ПРОЙДЕНА");

        return ok ? 0 : 1;
    }

    /// <summary>Инициализатор модуля выполнился до точки входа.</summary>
    private static bool InitializerRanFirst()
    {
        Console.WriteLine("Инициализатор модуля");

        bool ok = Report("выполнился до точки входа", Startup.BeforeMain > 0, Startup.BeforeMain.ToString());
        ok &= Report("записал себя первым", Startup.Order.Count > 0 && Startup.Order[0] == "инициализатор модуля", string.Join(", ", Startup.Order));

        return ok;
    }

    /// <summary>В параметр приходит текст выражения, а не его значение.</summary>
    private static bool ExpressionIsText()
    {
        Console.WriteLine();
        Console.WriteLine("Текст аргумента");

        const int a = 2;
        const int b = 3;

        string text = Capture(a + b > 10);
        bool ok = Report("пришло само выражение", text == "a + b > 10", text);

        string name = "нет";
        try
        {
            string? empty = null;
            ArgumentNullException.ThrowIfNull(empty);
        }
        catch (ArgumentNullException error)
        {
            name = error.ParamName ?? "нет";
        }

        ok &= Report("имя аргумента взято из места вызова", name == "empty", name);
        return ok;
    }

    /// <summary>Отказ от заполнения нулями не меняет результат.</summary>
    private static bool StackResultsAgree()
    {
        Console.WriteLine();
        Console.WriteLine("Память на стеке");

        bool ok = true;
        foreach (int size in Payloads.Sizes)
        {
            ok &= Report("размер " + size,
                Subjects.StackWithInit(size) == Subjects.StackWithoutInit(size),
                Subjects.StackWithInit(size).ToString());
        }

        return ok;
    }

    /// <summary>Текст выражения из места вызова.</summary>
    private static string Capture(bool condition, [CallerArgumentExpression(nameof(condition))] string? text = null) => text ?? string.Empty;

    /// <summary>Одна строка отчёта.</summary>
    private static bool Report(string name, bool ok, string detail)
    {
        Console.WriteLine((ok ? "  ок   " : "  СБОЙ ") + name + (detail.Length == 0 ? "" : ": " + detail));
        return ok;
    }
}
