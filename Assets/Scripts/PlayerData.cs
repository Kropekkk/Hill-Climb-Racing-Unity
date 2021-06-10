using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public int best_distance;

    public void SaveBestDistance()
    {
        PlayerPrefs.SetInt("BestDistance", best_distance);
    }
    public int GetBestDistance()
    {
        return PlayerPrefs.GetInt("BestDistance");
    }

}