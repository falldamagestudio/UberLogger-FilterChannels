# UberLogger-FilterChannels
Selective muting of channels for UberLogger

This provides a convenient way to selectively mute certain log channels.

Write your subsystems such that they do all their logging with `UberDebug.LogChannel(<subsystem name>, ...)`. You can then use this to selectively mute the subsystems you are not currently working with. You would typically only mute messages, but leave all warnings and errors visible.

A good approach is to have a central set of constants with all channel names, and associated filter levels. It is then easy for other developers to find and control the logging settings.

## How to use

- Copy [FilterChannels](Assets/FilterChannels) as-is to your project.
- Copy [InitUberLoggerChannelFilters.cs](Assets/Examples/InitUberLoggerChannelFilters.cs) and [LogChannels.cs](Assets/Examples/LogChannels.cs) to your project and modify as needed;
- Place [InitUberLoggerChannelFilters.cs](Assets/Examples/InitUberLoggerChannelFilters.cs) on an object in your scene. This will initialize the filter settings.
- Edit [LogChannels.cs](Assets/Examples/LogChannels.cs) to contain a list of channels that make sense for your project, and appropriate log filter levels.
