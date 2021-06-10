using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerData MyData;
    
    public Slider Fuel_UILevel;

    public float fuel_level;
    float fuelconsumption = 0.01f;

    public CarController MyCar;

    public Text BestDistanceText;

    public float currentdistance;
    float spawnpoint;

    void Start()
    {
        MyData = new PlayerData();
        fuel_level = 1;
        BestDistanceText.text = MyData.GetBestDistance().ToString();
        spawnpoint = Mathf.Abs(MyCar.transform.position.x);

    }

    void Update()
    {
        if (fuel_level > 0)
        {
            fuel_level -= fuelconsumption * Time.fixedDeltaTime;
            Fuel_UILevel.value = fuel_level;
        }
        currentdistance = MyCar.transform.position.x + spawnpoint;
        BestDistanceText.text = Mathf.RoundToInt(currentdistance).ToString();
    }
    void EndGame()
    {

    }
}
