# UberLogger-FilterChannels
Selective muting of channels for UberLogger

This provides a convenient way to selectively mute certain log channels.

Write your subsystems such that they do all their logging with `UberDebug.LogChannel(<subsystem name>, ...)`. You can then use this to selectively mute the subsystems you are not currently working with. You would typically only mute messages, but leave all warnings and errors visible.

A good approach is to have a central set of constants with all channel names, and associated filter levels. It is then easy for other developers to find and control the logging settings.
