using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float laneDistance = 3f;   // Distance between lanes
    public float moveSpeed = 10f;       // Speed of lane switching

    private int currentLane = 1;        // 0 = Left, 1 = Middle, 2 = Right

    void Update()
    {
        // Move Left (A key)
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentLane > 0)  // if not already at left
                currentLane--;
        }

        // Move Right (D key)
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentLane < 2)  // if not already at right
                currentLane++;
        }

        // Calculate target X position based on lane
        float targetX = (currentLane - 1) * laneDistance;
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);

        // Smooth movement towards target lane
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
