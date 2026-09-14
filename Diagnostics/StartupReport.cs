namespace AttributeProof.Diagnostics;

/// <summary>
/// Порядок выполнения. Отчёт показывает, что метод с атрибутом
/// ModuleInitializer отработал раньше точки входа, хотя его никто
/// не вызывал.
/// </summary>
internal static class StartupReport
{
    /// <summary>Выводит порядок событий.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Метод объявлен так:");
        Console.WriteLine();
        Console.WriteLine("  [ModuleInitializer]");
        Console.WriteLine("  internal static void Init()");
        Console.WriteLine();
        Console.WriteLine("В точке входа его никто не вызывает.");
        Console.WriteLine();
        Console.WriteLine("Порядок событий:");
        Console.WriteLine();

        for (int i = 0; i < Startup.Order.Count; i++)
        {
            Console.WriteLine("  " + (i + 1) + ". " + Startup.Order[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Отметка времени из инициализатора: " + Startup.BeforeMain);
        Console.WriteLine();
        Console.WriteLine("Требования к такому методу: статический, без параметров,");
        Console.WriteLine("возвращает void, не обобщённый и не внутри обобщённого типа,");
        Console.WriteLine("доступность internal или public. Иначе сборка не пройдёт.");
        Console.WriteLine();
        Console.WriteLine("В библиотеке классов такой метод один, в EventSource.");
        Console.WriteLine("Начиная с .NET 10 анализатор CA2255 предупреждает, что в");
        Console.WriteLine("библиотеках этот атрибут применять не стоит.");

        return 0;
    }
}
