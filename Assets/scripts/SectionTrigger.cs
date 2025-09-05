using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject roadPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Yeh trigger jis road ke andar hai uska parent
            Transform currentRoad = transform.parent;
            Transform endPoint = currentRoad.Find("EndPoint");

            if (endPoint != null)
            {
                // Bas Z axis me aage spawn karega
                Vector3 spawnPos = new Vector3(currentRoad.position.x,currentRoad.position.y,endPoint.position.z + 150); // x aur y axis fix rahega aur z axis ke aage spwan karega

                Instantiate(roadPrefab, spawnPos, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("EndPoint not found in: " + currentRoad.name);
            }
        }
    }
}
