using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace ExternalLibrary;

public static class ExternalClass {

    [SupportedOSPlatform("windows")]
    [DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsFloatW")]
    public static extern bool GetCharABCWidthsFloat(HandleRef hdc, uint firstChar, uint lastChar, IntPtr widths);
}