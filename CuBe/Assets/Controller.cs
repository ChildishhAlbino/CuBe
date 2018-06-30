using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private IInputManager inputManager;
    public Cube cube;
    private const int rotationSpeed = 1000;
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
        float x, y, z;
        GenerateRandomAngles(out x, out y, out z);
        var rotatePosition = new Vector3(x, y, z);
        cube.Rotate(rotatePosition);
    }

    private void GenerateRandomAngles(out float x, out float y, out float z)
    {
        x = Random.Range(1, 6) * 15;
        y = Random.Range(1, 6) * 15;
        z = Random.Range(1, 6) * 15;
        Debug.Log(x);
        Debug.Log(y);
        Debug.Log(z);
    }

    private void GetInputManager()
    {
        inputManager = InputManagerFactory.BuildInputManager(this);
    }

    public void ParseCollidedObject(GameObject gameObject)
    {
        if (gameObject == cube.gameObject)
        {
            RotateCube();
        }
    }
}

