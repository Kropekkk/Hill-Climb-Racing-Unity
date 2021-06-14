using UnityEngine;

public class VehicleData
{
    public int EngineLevel;
    public int SuspensionLevel;
    public int TiresLevel;
    public int FourWDLevel;

    public void SaveVehicleData(int id, int engine, int suspension, int tires, int fourWD)
    {
        PlayerPrefs.SetInt("EngineLevel" + id, engine);
        PlayerPrefs.SetInt("SuspensionLevel" + id, suspension);
        PlayerPrefs.SetInt("TiresLevel" + id, tires);
        PlayerPrefs.SetInt("4WDLevel"+id, fourWD);
    }
    public void GetVehicleData(int id)
    {
        EngineLevel = PlayerPrefs.GetInt("EngineLevel" + id);
        SuspensionLevel = PlayerPrefs.GetInt("SuspensionLevel" + id);
        TiresLevel = PlayerPrefs.GetInt("TiresLevel" + id);
        FourWDLevel = PlayerPrefs.GetInt("4WDLevel" + id);
    }
}