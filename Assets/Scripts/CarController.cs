using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;

    float movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        movement = Input.GetAxis("Horizontal");
        backTire.AddTorque(-movement * 100 * Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * 100 * Time.fixedDeltaTime);
    }
}
