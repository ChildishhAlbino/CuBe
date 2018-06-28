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
        GetInputManager();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.CheckForInput();
    }

    public void RotateCube()
    {
        int x, y, z;
        x = Random.Range(1, 6) * 15;
        y = Random.Range(1, 6) * 15;
        z = Random.Range(1, 6) * 15;
        cube.transform.Rotate(new Vector3(x, y, z));
    }

    private void GetInputManager()
    {
        inputManager = InputManagerFactory.BuildInputManager(this);
    }

    public void ParseCollidedObject(GameObject gameObject)
    {
        if(gameObject == cube.gameObject)
        {
            RotateCube();
        }    
    }
}

