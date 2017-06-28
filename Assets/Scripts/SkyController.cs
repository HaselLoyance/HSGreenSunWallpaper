using UnityEngine;

public class SkyController : MonoBehaviour
{
    public float rotationSpeed = -0.45f;

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}