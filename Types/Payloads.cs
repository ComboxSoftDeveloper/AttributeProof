namespace AttributeProof.Types;

/// <summary>Размеры, на которых снимаются замеры памяти на стеке.</summary>
internal static class Payloads
{
    /// <summary>От маленького буфера до такого, где заполнение нулями заметно.</summary>
    internal static readonly int[] Sizes = [64, 256, 1024, 4096];
}
