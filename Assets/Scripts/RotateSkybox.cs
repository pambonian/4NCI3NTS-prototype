using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    public float rotationSpeed = 1.2f;

    void Update()
    {
        // Rotates the skybox material
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
