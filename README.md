# AttributeProof

Замеры и проверки к статье «А чё, так можно было? Три недооценённых
атрибута .NET» — три атрибута, которые меняют результат компиляции.

BenchmarkDotNet 0.15.8, Release, .NET 8, .NET 9 и .NET 10 в одном запуске,
со снятием машинного кода.

Статья: **[ссылка]**

## Что проверяется

| Атрибут | Что делает | Чем показано |
| --- | --- | --- |
| `ModuleInitializer` | запускает метод раньше `Main` | отчёт `startup` |
| `CallerArgumentExpression` | передаёт текст выражения вместо результата | отчёт `expression`, замер `ArgumentBench` |
| `SkipLocalsInit` | убирает заполнение памяти нулями | замер `LocalsInitBench` |

## Стенд

| Процессор | Система |
| --- | --- |
| Intel Core i9-10900KF 3.70GHz, 10 ядер | Windows 10 22H2 |
| AMD Ryzen 9 5950X 3.39GHz, 16 ядер | Windows 10 1809 |
| Intel Xeon W-2255 3.70GHz, 10 ядер | Windows Server 2022 |
| Intel Xeon Silver 4314 2.40GHz, 2 CPU, 32 ядра | Windows Server 2022 |

Все машины x64. Выгрузки лежат в `Results`: `Comp_1` — i9-10900KF, `Comp_2` —
Ryzen 9 5950X, `Comp_3` — Xeon W-2255, `Comp_4` — Xeon Silver 4314.

## Результаты

### Порядок выполнения

```
Порядок событий:

  1. инициализатор модуля
  2. точка входа
```

Одинаково на четырёх машинах и трёх рантаймах.

### Текст выражения вместо значения

```
Что попадает в text при разных вызовах:

  a + b > 10                            ложь
  a * b == 6                            истина
  empty is null                         истина
  !string.IsNullOrEmpty(empty)          ложь

Так устроены проверки из библиотеки классов:

  ArgumentNullException             имя аргумента: empty
  ArgumentOutOfRangeException       имя аргумента: a - 5
```

Подстановка происходит при сборке, поэтому на времени она не сказывается:

| Способ | i9-10900KF | Ryzen 9 5950X | Xeon W-2255 | Xeon Silver 4314 |
| --- | --- | --- | --- | --- |
| из библиотеки | 0,3944 | 0,2656 | 0,7058 | 0,6679 |
| написано явно | 0,3969 | 0,2646 | 0,6427 | 0,7231 |

Наносекунды, .NET 10.

### Отказ от заполнения памяти нулями

| Буфер | i9-10900KF | Ryzen 9 5950X | Xeon W-2255 | Xeon Silver 4314 |
| --- | --- | --- | --- | --- |
| 64 байта | 2,452 / 1,765 | 2,082 / 4,695 | 2,793 / 2,419 | 5,409 / 4,512 |
| 256 байт | 6,475 / 1,729 | 5,741 / 4,691 | 8,530 / 2,208 | 13,015 / 4,501 |
| 1024 байта | 25,505 / 1,769 | 17,712 / 4,703 | 31,281 / 2,574 | 48,282 / 4,566 |
| 4096 байт | 103,474 / 2,043 | 71,811 / 4,939 | 126,066 / 2,685 | 189,264 / 4,827 |

Наносекунды, с заполнением нулями и без, .NET 10. На четырёх килобайтах
разница от 14,5 до 50,6 раза.

На 64 байтах выигрыш в лучшем случае 1,39 раза, а на Ryzen 9 5950X версия
без заполнения нулями медленнее: 4,695 против 2,082. На этой машине время
без заполнения не меняется с ростом буфера и составляет около 4,7 наносекунды,
тогда как на других процессорах оно в пределах 1,7–2,7.

## Как воспроизвести

Нужны SDK .NET 8, 9 и 10: BenchmarkDotNet поднимает по процессу на рантайм.

```
dotnet --list-sdks
```

В пути к проекту не должно быть запятых и точек с запятой. BenchmarkDotNet
собирает вспомогательный проект и передаёт путь в MSBuild без кавычек, тот
разбирает эти знаки как разделители списка свойств и падает с MSB1006.
Батник проверяет путь и останавливается сразу.

Весь прогон одной командой:

```
all.bat
```

Вручную, без скрипта:

```
dotnet run -c Release -f net10.0 -- checks
dotnet run -c Release -f net10.0 -- startup
dotnet run -c Release -f net10.0 -- expression
dotnet run -c Release -f net10.0 -- --filter *
dotnet run -c Release -f net10.0 -- --filter *LocalsInitBench*
```

Аргумент `noasm` выключает снятие машинного кода.

Причина любого сбоя записывается в `Bdn\AttributeProof.log`.

## Как устроен замер

Все измеряемые методы лежат в `Subjects.cs`, у каждого `NoInlining`. Иначе
компилятор перенесёт код метода в замер, а вместе с ним туда попадёт
и заполнение памяти нулями.

`SkipLocalsInit` проставлен на отдельных методах, а не на классе: на классе
он подействует и на тот вариант, который заполняет память нулями. Атрибуту
нужен небезопасный контекст, поэтому в файле проекта включён
`AllowUnsafeBlocks`.

В замере проверки аргумента на вход всегда передаётся непустая строка,
поэтому проверка на `null` ни разу не срабатывает. Так в замер попадает
только сама проверка, без обработки исключения.

## Что проверялось и чем

| Что проверялось | Чем |
| --- | --- |
| Инициализатор модуля выполняется раньше точки входа | отчёт `checks` сравнивает порядок событий |
| В параметр приходит текст выражения, а не значение | отчёт `checks` сверяет строку с ожидаемой |
| Имя аргумента в исключении берётся из места вызова | отчёт `checks` читает `ParamName` |
| Отказ от заполнения нулями не меняет результат | отчёт `checks` сравнивает оба варианта на четырёх размерах |
| Результат не зависит от размера буфера | замер на 64, 256, 1024 и 4096 байтах |
| Дело не в сборщике мусора | режим `DOTNET_gcServer=1` |
| Дело не в конкретной машине | четыре машины, выгрузки всех четырёх в `Results` |
| Дело не в конкретной версии | .NET 8, 9 и 10 в одном запуске |

Все замеры сняты на x64 под Windows.

Дизассемблер на Linux требует установленного `perf`. Выключается аргументом
`noasm`.

## Отчёты

```
Bdn\results\                    отчёты BenchmarkDotNet: csv, md, html, машинный код
Bdn\AttributeProof.log          журнал прогона: причины сбоев только здесь
Results\Comp_N\
    checks_netN.0.txt           сверка, код возврата
    checks_netN.0_servergc.txt  то же на серверном сборщике
    startup_netN.0.txt          порядок выполнения
    expression_netN.0.txt       текст выражения вместо значения
    probe_noasm.txt             проба на одном классе без дизассемблера
    probe_asm.txt               та же проба с дизассемблером
    bench\                      отчёты BenchmarkDotNet
```

## Что где лежит

```
AttributeProof.csproj        многоцелевой: net8.0, net9.0, net10.0
AttributeProof.slnx
Program.cs                   точка входа, разбор аргументов
Subjects.cs                  все измеряемые методы
README.md
all.bat                      весь прогон одной командой
Benchmarks\
    LocalsInitBench.cs       отказ от заполнения памяти нулями
    ArgumentBench.cs         проверка аргумента
Types\
    BenchmarkConfig.cs       три рантайма, дизассемблер, колонки и журнал
    Payloads.cs              размеры буферов
Diagnostics\
    Checks.cs                сверка, код возврата
    Startup.cs               инициализатор модуля
    StartupReport.cs         отчёт о порядке выполнения
    Expressions.cs           текст выражения вместо значения
Results\
    Comp_1 .. Comp_4\        выгрузки прогона, по папке на машину
```

## Ссылки

- [ModuleInitializerAttribute](https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.moduleinitializerattribute)
- [CA2255: атрибут не для библиотек](https://learn.microsoft.com/dotnet/fundamentals/code-analysis/quality-rules/ca2255)
- [Как этим пользуется EventSource](https://github.com/dotnet/runtime/blob/60629d14374c56f1cb51819049ad1fa529307f8d/src/libraries/System.Private.CoreLib/src/System/Diagnostics/Tracing/EventSource.cs#L3874)
- [ArgumentNullException.ThrowIfNull](https://github.com/dotnet/runtime/blob/60629d14374c56f1cb51819049ad1fa529307f8d/src/libraries/System.Private.CoreLib/src/System/ArgumentNullException.cs#L55)
- [SkipLocalsInit включён на всю библиотеку классов](https://github.com/dotnet/runtime/blob/60629d14374c56f1cb51819049ad1fa529307f8d/src/libraries/Directory.Build.targets#L220)
- [SkipLocalsInitAttribute](https://learn.microsoft.com/dotnet/api/system.runtime.compilerservices.skiplocalsinitattribute)
- [Ошибка CS0227 без небезопасного контекста](https://learn.microsoft.com/dotnet/csharp/language-reference/compiler-messages/unsafe-code-errors)

## Границы

Числа в этом файле берутся только из отчётов.

`SkipLocalsInit` не гарантирует, что память не будет заполнена нулями:
атрибут снимает требование, а не запрещает заполнение. Читать буфер раньше,
чем в него что-то записали, нельзя — там будут данные от предыдущих вызовов.

Ссылки на исходники .NET даны на тег `v10.0.0`, коммит зафиксирован: `main`
уедет, и номера строк перестанут совпадать.
