using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Cube cube;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RotateCube()
    {
        cube.transform.Rotate(new Vector3(45, 90, 0));
    }
}

