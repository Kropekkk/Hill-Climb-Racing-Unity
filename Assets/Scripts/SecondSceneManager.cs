using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondSceneManager : MonoBehaviour
{
    public Text Totalcoins;

    void Start()
    {
        PlayerData MyData = new PlayerData();
        Totalcoins.text = MyData.GetCoins().ToString();
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
}