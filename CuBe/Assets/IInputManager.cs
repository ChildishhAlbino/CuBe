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
    public static IInputManager BuildInputManager(Controller controller)
    {
        if (Application.isMobilePlatform)
        {
            Debug.Log("Mobile!");
            return new TouchInputManager(controller);
        }
        else
        {
            return new MouseAndKeyboardInputManager(controller);
        }
    }
}

public class MouseAndKeyboardInputManager : IInputManager
{
    public Controller controller;

    public MouseAndKeyboardInputManager(Controller controller)
    {
        this.controller = controller;
    }

    public void CheckForInput()
    {
        //determine a click
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            if(hit.collider != null)
            {
                controller.ParseCollidedObject(hit.collider.gameObject);
            }
        }
        //fire a raycast
        //send collider to controller
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
    private Controller controller;

    public TouchInputManager(Controller controller)
    {
        this.controller = controller;
    }
    public void CheckForInput()
    {
        Debug.Log("I'm on a mobile device");
        if (IsTouch())
        {
            Touch touch = Input.GetTouch(0);
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            if(Physics.Raycast(ray, out raycastHit))
            {
                if(raycastHit.collider != null)
                {
                    controller.ParseCollidedObject(raycastHit.collider.gameObject);
                }
            }
        }

    }

    public bool IsTouch()
    {
        if (Input.touches.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
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
