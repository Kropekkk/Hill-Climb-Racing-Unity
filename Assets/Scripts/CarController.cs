using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Rigidbody2D Car;
    private int TireTorque;
    private int CarBodyTorque;
    public JointSuspension2D RearWheel,FrontWheel;
    public WheelJoint2D Rear, Front;

    float movement;

    private void Start()
    {
        VehicleData MyVehicle = new VehicleData();
        PlayerData MyData = new PlayerData();
        MyVehicle.GetVehicleData(MyData.GetCurrentVehicle());
        TireTorque = 80 + MyVehicle.EngineLevel + MyVehicle.FourWDLevel + MyVehicle.TiresLevel;
        CarBodyTorque = 150 + MyVehicle.EngineLevel + MyVehicle.FourWDLevel;
        RearWheel.dampingRatio = 0.7f + MyVehicle.SuspensionLevel*0.01f;
        RearWheel.angle = 90;
        RearWheel.frequency = 3;
        FrontWheel.dampingRatio = 0.7f + MyVehicle.SuspensionLevel * 0.01f;
        FrontWheel.angle = 90;
        FrontWheel.frequency = 3;
        Rear.suspension = RearWheel;
        Front.suspension = FrontWheel;
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