using System.Runtime.CompilerServices;

namespace AttributeProof.Diagnostics;

/// <summary>
/// Код, который выполняется до точки входа. Метод с атрибутом ModuleInitializer
/// вызывается один раз при загрузке сборки, раньше любого другого кода модуля.
///
/// Требования к такому методу: статический, без параметров, возвращает void,
/// не обобщённый и не внутри обобщённого типа, доступность internal или public.
/// </summary>
internal static class Startup
{
    /// <summary>Отметка времени, поставленная до точки входа.</summary>
    internal static long BeforeMain { get; private set; }

    /// <summary>Порядок событий, чтобы отчёт мог его показать.</summary>
    internal static readonly List<string> Order = [];

    /// <summary>Вызывается средой выполнения, а не из кода.</summary>
    [ModuleInitializer]
    internal static void Init()
    {
        BeforeMain = Environment.TickCount64;
        Order.Add("инициализатор модуля");
    }
}
