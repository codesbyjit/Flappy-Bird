using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour {
    private int counter = 0;

    private void Start() {
        Debug.Log("GameHandler.Start");

        FunctionPeriodic.Create(() => {
            CMDebug.TextPopupMouse("Counter: " + counter);
            counter++;
        }, 0.3f);
    }
}
