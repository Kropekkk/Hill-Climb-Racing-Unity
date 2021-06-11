using System.Collections;
using System.Collections.Generic;
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
}