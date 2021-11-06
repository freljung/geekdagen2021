using System;

namespace ca1008
{
    // CA1008: Enums should have zero value
    // https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1008
    public enum TraceLevel
    {
        Off = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Verbose = 4
    }

    [Flags]
    public enum TraceOptions
    {
        None = 0,
        CallStack = 0x01,
        LogicalStack = 0x02,
        DateTime = 0x04,
        Timestamp = 0x08,
    }

    /// <summary>
    /// <para>
    /// <b>Problem:</b> Default-värdet av en enumtyp är 0 och inte det första deklarerade värdet.
    /// </para>
    /// 
    /// <para>
    /// <b>Lösning:</b> Antingen utöka med en ny typ, exempelvis None och sätt till 0, eller ändra
    /// så det vanligaste eller lämpligaste standardvärdet har 0.
    /// </para>
    /// 
    /// <para>
    /// <b>Konfiguration:</b> Som standard används bara regeln på externt synliga enumtyper. Det kan konfigeras i .editorconfig
    /// via dotnet_code_quality.CA1012.api_surface = private, internal
    /// </para>
    /// </summary>
    [Flags]
    public enum BadTraceOptions
    {
        CallStack = 0,
        LogicalStack = 0x01,
        DateTime = 0x02,
        Timestamp = 0x04,
    }

    class UseBadTraceOptions
    {
        static void MainTrace()
        {
            // Set the flags.
            BadTraceOptions badOptions =
               BadTraceOptions.LogicalStack | BadTraceOptions.Timestamp;

            // Check whether CallStack is set.
            if ((badOptions & BadTraceOptions.CallStack) ==
                BadTraceOptions.CallStack)
            {
                // This 'if' statement is always true.
            }
        }
    }
}