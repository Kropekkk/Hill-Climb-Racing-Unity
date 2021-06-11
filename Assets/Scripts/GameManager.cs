using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerData MyData;
    
    public Slider Fuel_UILevel;

    public float fuel_level=1;
    float fuelconsumption = 0.01f;

    public CarController MyCar;

    public Text BestDistanceT;
    public Text CoinT;

    public int currentdistance;
    public int currentcoins;
    float spawnpoint;

    public GameObject PausePanel;
    public GameObject GameUI;

    void Start()
    {
        Time.timeScale = 1f;
        MyData = new PlayerData();
        BestDistanceT.text = MyData.GetBestDistance().ToString();
        spawnpoint = Mathf.Abs(MyCar.transform.position.x);
        currentcoins = MyData.GetCoins();
    }

    void Update()
    {
        FuelSystem();
        DistanceSystem();
        CoinSystem();
    }
    void EndGame()
    {
        
    }
    void FuelSystem()
    {
        if (fuel_level > 0)
        {
            fuel_level -= fuelconsumption * Time.fixedDeltaTime;
            Fuel_UILevel.value = fuel_level;
        }
    }
    void DistanceSystem()
    {
        currentdistance = Mathf.RoundToInt(MyCar.transform.position.x + spawnpoint);
        if (currentdistance > MyData.GetBestDistance())
        {
            MyData.SaveBestDistance(currentdistance);
        }
        BestDistanceT.text = currentdistance.ToString() + " /Best distance:" + MyData.GetBestDistance().ToString();
    }
    void CoinSystem()
    {
        CoinT.text = currentcoins.ToString();
        MyData.SaveCoins(currentcoins);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        GameUI.SetActive(false);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
        GameUI.SetActive(true);
    }
}