using UnityEngine;

public class Movement : MonoBehaviour
{

    void Update()
    {
        // Move ground backwards
        transform.position -= new Vector3(0, 0, Game_Manager.speed * Time.deltaTime);

        // Destroy when ground moves too far back
        if (transform.position.z < -65f)
        {
            Destroy(gameObject);
        }
    }
}
