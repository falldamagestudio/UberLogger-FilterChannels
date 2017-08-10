
using System.Collections.Generic;

public class LogChannels
{
    public static readonly string TestChannel1 = "TestChannel1";
    public static readonly string TestChannel2 = "TestChannel2";
    public static readonly string TestChannel3 = "TestChannel3";
    public static readonly string TestChannel4 = "TestChannel4";
    public static readonly string TestChannel5 = "TestChannel5";

    // Filter level used for standard Unity log messages, and all channels whose filtering levels have not been set manually
    public static readonly UberLoggerFilterChannels.FilterLevel DefaultFilterLevel = UberLoggerFilterChannels.FilterLevel.Message;

    // Filter levels for individual channels
    public static readonly Dictionary<string, UberLoggerFilterChannels.FilterLevel> FilterLevels = new Dictionary<string, UberLoggerFilterChannels.FilterLevel>
    {
        { TestChannel1, UberLoggerFilterChannels.FilterLevel.Message },
        { TestChannel2, UberLoggerFilterChannels.FilterLevel.Warning },
        { TestChannel3, UberLoggerFilterChannels.FilterLevel.Error },
        { TestChannel4, UberLoggerFilterChannels.FilterLevel.None },
    };
}
