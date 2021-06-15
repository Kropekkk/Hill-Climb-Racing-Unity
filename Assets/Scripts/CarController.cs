using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Rigidbody2D Car;
    private int TireTorque;
    private int CarBodyTorque;

    float movement;

    private void Start()
    {
        VehicleData MyVehicle = new VehicleData();
        PlayerData MyData = new PlayerData();
        MyVehicle.GetVehicleData(MyData.GetCurrentVehicle());
        TireTorque = 80 + MyVehicle.EngineLevel + MyVehicle.FourWDLevel + MyVehicle.TiresLevel;
        CarBodyTorque = 150 + MyVehicle.EngineLevel + MyVehicle.FourWDLevel;
    }
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