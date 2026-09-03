// Build: 6ce9f0f5fa6e3c12fa2ed856794458d3
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
