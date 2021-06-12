using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager GameManager;
    public int value;

    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.totalcoins += value;
        GameManager.currentcoins += value;
        Destroy(gameObject);
    }
}