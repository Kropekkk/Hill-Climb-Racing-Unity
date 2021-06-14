using UnityEngine;

public class PlayerData
{
    public void SaveBestDistance(int best_distance)
    {
        PlayerPrefs.SetInt("BestDistance", best_distance);
    }
    public int GetBestDistance()
    {
        return PlayerPrefs.GetInt("BestDistance");
    }
    public void SaveCoins(int coins)
    {
        PlayerPrefs.SetInt("Coins", coins);
    }
    public int GetCoins()
    {
        return PlayerPrefs.GetInt("Coins");
    }
    public void SaveStageSelected(string map_name)
    {
        PlayerPrefs.SetString("StageSelected", map_name);
    }
    public string GetStageSelected()
    {
        return PlayerPrefs.GetString("StageSelected");
    }
    public void SaveCurrentVehicle(int id)
    {
        PlayerPrefs.SetInt("VehicleID", id);
    }
    public int GetCurrentVehicle()
    {
        return PlayerPrefs.GetInt("VehicleID");
    }
}