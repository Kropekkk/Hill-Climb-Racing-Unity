using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform car;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - car.position;
    }
    void Update()
    {
        transform.position = car.position+offset;
    }
}