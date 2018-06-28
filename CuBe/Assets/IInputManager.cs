using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputManager
{
    void CheckForInput();
    bool IsTouch();
    void ParseSwipe(Swipe swipe);
}

public enum Swipe
{
    up,
    down,
    left,
    right
}
