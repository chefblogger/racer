using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controll : MonoBehaviour
{
   
   public float movementSpeed = 10.0f;
public float rotationSpeed = 200.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0,0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);  
    }
}
