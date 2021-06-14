using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject GameUI;
    public GameObject EndPanel;
    public Text EndCoins;
    public Text Enddistance;
    public Text BestDistanceT;
    public Text CoinT;
    public Slider Fuel_UILevel;

    public CarController MyCar;
    public PlayerData MyData;

    public float fuel_level;
    float fuelconsumption = 0.05f;

    public int currentdistance;
    public int totalcoins;
    public int currentcoins;
    float spawnpoint;

    void Start()
    {
        fuel_level = 1;
        Time.timeScale = 1f;
        MyData = new PlayerData();
        BestDistanceT.text = MyData.GetBestDistance().ToString();
        spawnpoint = Mathf.Abs(MyCar.transform.position.x);
        totalcoins = MyData.GetCoins();
    }

    private void FixedUpdate()
    {
        FuelSystem();
        DistanceSystem();
        CoinSystem();
    }
    void FuelSystem()
    {
        if (fuel_level > 0)
        {
            fuel_level -= fuelconsumption * Time.fixedDeltaTime;
            Fuel_UILevel.value = fuel_level;
        }
        else
        {
            EndGame();
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
        CoinT.text = totalcoins.ToString();
        MyData.SaveCoins(totalcoins);
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
    public void EndGame()
    {
        GameUI.SetActive(false);
        EndPanel.SetActive(true);
        Time.timeScale = 0f;

        EndCoins.text = "Earned coins: " + currentcoins.ToString();
        Enddistance.text = "Distance: " + currentdistance.ToString();
    }
    public void GoBack()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
    }
}