using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ThirdSceneManager : MonoBehaviour
{
    public Text Totalcoins;
    public Text MapSelected;

    public Text LevelEngine;
    public Text CostEngine;

    public Text LevelSuspension;
    public Text CostSuspension;

    public Text LevelTires;
    public Text CostTires;

    public Text Level4WD;
    public Text Cost4WD;

    int Engine_cost;
    int Suspension_cost;
    int Tires_cost;
    int FourWD_cost;

    PlayerData MyData;
    VehicleData MyVehicle;

    int currentcoins;

    void Start()
    {        
        MyData = new PlayerData();
        currentcoins = MyData.GetCoins();
        Totalcoins.text = currentcoins.ToString();
        MapSelected.text = MyData.GetStageSelected();
        MyVehicle = new VehicleData();
        GetData();      
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(1);
    }
    public void BuyEngine()
    {
        if(currentcoins>=Engine_cost && MyVehicle.EngineLevel<13)
        {
            Buy(Engine_cost);
            MyVehicle.SaveVehicleData(MyData.GetCurrentVehicle(), MyVehicle.EngineLevel+1, MyVehicle.SuspensionLevel, MyVehicle.TiresLevel, MyVehicle.FourWDLevel);
            GetData();                           
        }       
    }
    public void BuySuspension()
    {
        if(currentcoins>=Suspension_cost && MyVehicle.SuspensionLevel<13)
        {
            Buy(Suspension_cost);
            MyVehicle.SaveVehicleData(MyData.GetCurrentVehicle(), MyVehicle.EngineLevel, MyVehicle.SuspensionLevel + 1, MyVehicle.TiresLevel, MyVehicle.FourWDLevel);
            GetData();
        }  
    }
    public void BuyTires()
    {
        if(currentcoins>=Tires_cost && MyVehicle.TiresLevel<13)
        {
            Buy(Tires_cost);
            MyVehicle.SaveVehicleData(MyData.GetCurrentVehicle(), MyVehicle.EngineLevel, MyVehicle.SuspensionLevel, MyVehicle.TiresLevel + 1, MyVehicle.FourWDLevel);
            GetData();  
        }       
    }
    public void Buy4WD()
    {
        if(currentcoins>=FourWD_cost && MyVehicle.FourWDLevel<13)
        {
            Buy(FourWD_cost);
            MyVehicle.SaveVehicleData(MyData.GetCurrentVehicle(), MyVehicle.EngineLevel, MyVehicle.SuspensionLevel, MyVehicle.TiresLevel, MyVehicle.FourWDLevel + 1);
            GetData();      
        }      
    }
    void GetData()
    {     
        MyVehicle.GetVehicleData(MyData.GetCurrentVehicle());

        Engine_cost = 5000 + MyVehicle.EngineLevel * 2500;
        Suspension_cost = 5000 + MyVehicle.SuspensionLevel * 2500;
        Tires_cost = 5000 + MyVehicle.TiresLevel * 2500;
        FourWD_cost = 5000 + MyVehicle.FourWDLevel * 2500;

        LevelEngine.text = "Level " + MyVehicle.EngineLevel + " / " + "13";
        LevelSuspension.text = "Level " + MyVehicle.SuspensionLevel + " / " + "13";
        LevelTires.text = "Level " + MyVehicle.TiresLevel + " / " + "13";
        Level4WD.text = "Level " + MyVehicle.FourWDLevel + " / " + "13";  
                 
        CostEngine.text = "Cost " + (Engine_cost).ToString();
        CostSuspension.text = "Cost " +  (Suspension_cost).ToString();
        CostTires.text = "Cost " +  (Tires_cost).ToString();
        Cost4WD.text = "Cost " + (FourWD_cost).ToString();
    }
    void Buy(int cost)
    {
        currentcoins -= cost;
        Totalcoins.text = currentcoins.ToString();
        MyData.SaveCoins(currentcoins);
    }
}