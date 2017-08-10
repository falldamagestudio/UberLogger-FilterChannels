using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTestMessages : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("Standard log operation");

        UberDebug.LogChannel(LogChannels.TestChannel1, "Log message to TestChannel1");
        UberDebug.LogChannel(LogChannels.TestChannel2, "Log message to TestChannel2");
        UberDebug.LogChannel(LogChannels.TestChannel3, "Log message to TestChannel3");
        UberDebug.LogChannel(LogChannels.TestChannel4, "Log message to TestChannel4");
        UberDebug.LogChannel(LogChannels.TestChannel5, "Log message to TestChannel5");
        UberDebug.LogWarningChannel(LogChannels.TestChannel1, "Log warning to TestChannel1");
        UberDebug.LogWarningChannel(LogChannels.TestChannel2, "Log warning to TestChannel2");
        UberDebug.LogWarningChannel(LogChannels.TestChannel3, "Log warning to TestChannel3");
        UberDebug.LogWarningChannel(LogChannels.TestChannel4, "Log warning to TestChannel4");
        UberDebug.LogWarningChannel(LogChannels.TestChannel5, "Log warning to TestChannel5");
        UberDebug.LogErrorChannel(LogChannels.TestChannel1, "Log error to TestChannel1");
        UberDebug.LogErrorChannel(LogChannels.TestChannel2, "Log error to TestChannel2");
        UberDebug.LogErrorChannel(LogChannels.TestChannel3, "Log error to TestChannel3");
        UberDebug.LogErrorChannel(LogChannels.TestChannel4, "Log error to TestChannel4");
        UberDebug.LogErrorChannel(LogChannels.TestChannel5, "Log error to TestChannel5");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
