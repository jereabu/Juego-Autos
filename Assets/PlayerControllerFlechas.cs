using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerFlechas : MonoBehaviour
{
    public float rotationSpeed;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
        transform.Translate(0,0,movementSpeed);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
        transform.Translate(0,0,-movementSpeed);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(0,rotationSpeed,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Rotate(0,-rotationSpeed,0);
        }
    }
}