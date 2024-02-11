using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.forward; // Default rotation axis is up
    public float rotationSpeed = 10f; // Rotation speed in degrees per second

    void Update()
    {
        // Apply rotation around the given axis at the specified speed
        // lentil
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
