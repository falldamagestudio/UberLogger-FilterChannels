using System;
using System.Collections.Generic;
using UberLogger;
using UnityEngine;

/// <summary>
/// Different filtering rules for different channels, plus a default level for all non-explicit channels
/// The main use of this filter mechanism is to have lots of logging present in an application, but
///   then set most subsystem-specific logging to "Warnings and up only please" when not working with
///   those specific subsystems
/// </summary>
public class UberLoggerFilterChannels : UberLogger.IFilter
{
    public enum FilterLevel
    {
        Message,
        Warning,
        Error,
        None
    }

    public readonly Dictionary<string, FilterLevel> PerChannelFilterLevels;
    public readonly FilterLevel DefaultFilterLevel;

    public UberLoggerFilterChannels(FilterLevel defaultFilterLevel, Dictionary<string, FilterLevel> perChannelFilterLevels)
    {
        PerChannelFilterLevels = perChannelFilterLevels;
        DefaultFilterLevel = defaultFilterLevel;
    }

    /// <summary>
    /// Given a message channel and a severity level, determine whether the channel filter levels allow the message to pass through
    /// Returns true if the message should be logged, and false if it should be silenced
    /// </summary>
    public bool ApplyFilter(string channel, UnityEngine.Object source, LogSeverity severity, object message, params object[] par)
    {
        FilterLevel channelFilterLevel = DefaultFilterLevel;
        if (PerChannelFilterLevels.ContainsKey(channel))
            channelFilterLevel = PerChannelFilterLevels[channel];

        switch (severity)
        {
            case LogSeverity.Message:
                return channelFilterLevel == FilterLevel.Message;
            case LogSeverity.Warning:
                return channelFilterLevel == FilterLevel.Message || channelFilterLevel == FilterLevel.Warning;
            case LogSeverity.Error:
                return channelFilterLevel != FilterLevel.None;
            default:
                throw new NotImplementedException();
        }
    }
}
