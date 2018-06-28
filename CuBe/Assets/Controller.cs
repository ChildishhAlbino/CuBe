using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private IInputManager inputManager;
    public Cube cube;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.CheckForInput();
    }

    public void RotateCube()
    {
        cube.transform.Rotate(new Vector3(45, 90, 0));
    }

    private void GetInputManager()
    {
        inputManager = InputManagerFactory.BuildInputManager();
    }
}

