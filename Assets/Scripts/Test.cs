using UnityEngine;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    
    public Move moveScript;
    public GameObject thisIsAGameObject;
    public Transform thisIsATransform;
    public float rotationSpeed = 90f; // degrees per second
    
    /*
    public List<float> thisIsAListOfFloats = new List<float>();

    public float moveSpeed = 10f;

    public bool thisIsABoolean = true;

    public string thisIsAString = "Hello, World!";
    */
    
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveScript.MoveMe();
        }
        if (Input.GetKey(KeyCode.A))
        {
            thisIsATransform.Translate(1*Time.deltaTime, 0, 0);
        }
    }
}
