using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Terrain")
        {
            GameManager.EndGame();
        }       
    }
}