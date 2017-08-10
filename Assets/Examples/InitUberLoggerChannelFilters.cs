using UnityEngine;

public class InitUberLoggerChannelFilters : MonoBehaviour {

	void Awake() {
        UberLogger.Logger.AddFilter(new UberLoggerFilterChannels(LogChannels.DefaultFilterLevel, LogChannels.FilterLevels));
	}
}
