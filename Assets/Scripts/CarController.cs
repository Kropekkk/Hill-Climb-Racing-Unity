using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Rigidbody2D Car;
    private int TireTorque = 100;
    private int CarBodyTorque = 150;

    float movement;
    
    private void FixedUpdate()
    {     
        { 
            movement = Input.GetAxis("Horizontal");
            backTire.AddTorque(-movement * TireTorque * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * TireTorque * Time.fixedDeltaTime);
            Car.AddTorque(movement * CarBodyTorque * Time.fixedDeltaTime);
        }
    }
}