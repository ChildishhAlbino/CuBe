using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public List<Side> sides = new List<Side>();
    public float rotationSpeed = 0.2f;
    public Quaternion rotation;
    public float progress;
    bool rotating = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rotating)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, progress);
            progress += (rotationSpeed * Time.deltaTime);
            if (transform.rotation == rotation)
            {
                rotating = false;
                progress = 0;
            }
        }
        
    }

    public void Rotate(Vector3 toBeRotated)
    {
        Debug.Log("Cube should rotate");
        rotation = Quaternion.Euler(toBeRotated + transform.rotation.eulerAngles);
        progress = Mathf.Clamp01(rotationSpeed * Time.deltaTime);
        rotating = true;
    }
}
