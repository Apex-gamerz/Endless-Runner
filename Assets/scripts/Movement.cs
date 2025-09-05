// Movement.cs
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        transform.position -= new Vector3(0, 0, GameManager.platformSpeed * Time.deltaTime);

        if (transform.position.z <= -60f)
        {
            Destroy(gameObject);
        }
    }
}
