// GameManager.cs
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float platformSpeed = 4f; // shared speed
    public float increment = 0.2f;           // speed increase per second

    private void Start()
    {
        platformSpeed = 4f;
    }

    void Update()
    {
        if (platformSpeed < 10)
        { 
            platformSpeed += increment * Time.deltaTime;
        }
    }
}
