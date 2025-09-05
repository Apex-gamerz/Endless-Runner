using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;        // Player to follow
    public Vector3 offset;          // Camera offset from player
    public float smoothSpeed = 5f;  // Higher = snappier, lower = smoother

    void LateUpdate()
    {
        // Desired camera position = player position + offset
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move from current camera position to desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Apply new position
        transform.position = smoothedPosition;

        // Optional: make camera look at the player
        transform.LookAt(target);
    }
}
