using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameManager GameManager;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.fuel_level = 1;
        Destroy(gameObject);
    }
}