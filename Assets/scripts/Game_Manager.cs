using UnityEngine;

public class Game_Manager : MonoBehaviour
{

    public static float speed;

    private float increment = 0.1f;

    private void Start()
    {
        speed = 4f;
    }

    private void Update()
    {
        speed += Time.deltaTime * increment;
    }





}
