using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonConsecutiveEvents : MonoBehaviour
{
    public UnityEvent[] events;

    private int _clickCount;

    public void Click()
    {
        events[_clickCount].Invoke();

        _clickCount++;
    }
}
