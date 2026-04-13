using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE0250;

public readonly struct Data(ReadOnlySpan<char> input, Span<char> buffer)
{
    private readonly ReadOnlySpan<char> Input = input;
    private readonly Span<char> Buffer = buffer;
}