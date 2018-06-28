using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputManager
{
    void CheckForInput();
    bool IsTouch();
    void ParseSwipe(Swipe swipe);
}

public static class InputManagerFactory
{
    public static IInputManager BuildInputManager()
    {
        if (Application.isMobilePlatform)
        {
            return new TouchInputManager();
        }
        else
        {
            return new MouseAndKeyboardInputManager();
        }
    }
}

public class MouseAndKeyboardInputManager : IInputManager
{
    public void CheckForInput()
    {
        throw new System.NotImplementedException();
    }

    public bool IsTouch()
    {
        throw new System.NotImplementedException();
    }

    public void ParseSwipe(Swipe swipe)
    {
        throw new System.NotImplementedException();
    }
}

public class TouchInputManager : IInputManager
{
    public void CheckForInput()
    {
        throw new System.NotImplementedException();
    }

    public bool IsTouch()
    {
        throw new System.NotImplementedException();
    }

    public void ParseSwipe(Swipe swipe)
    {
        throw new System.NotImplementedException();
    }
}

public enum Swipe
{
    up,
    down,
    left,
    right
}
