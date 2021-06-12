using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstSceneManager : MonoBehaviour
{
    public Text Totalcoins;

    private void Start()
    {
        PlayerData MyData = new PlayerData();
        Totalcoins.text = MyData.GetCoins().ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void LeaveGame()
    {
        Application.Quit();
    }
}