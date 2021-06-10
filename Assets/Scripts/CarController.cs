using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Rigidbody2D Car;

    float movement;
    
    private void FixedUpdate()
    {     
        { 
            movement = Input.GetAxis("Horizontal");
            backTire.AddTorque(-movement * 100 * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * 100 * Time.fixedDeltaTime);
            Car.AddTorque(movement * 100 * Time.fixedDeltaTime);
        }
    }
}
