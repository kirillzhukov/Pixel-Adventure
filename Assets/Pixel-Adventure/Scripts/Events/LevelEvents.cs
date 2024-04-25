using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelEvents
{
    public static UnityEvent OnLevelSwitch = new UnityEvent();

    public static void SendLevelSwicth()
    {
        OnLevelSwitch.Invoke();
    }
}
