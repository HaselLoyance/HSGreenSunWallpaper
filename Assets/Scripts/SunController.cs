using UnityEngine;

public class SunController : MonoBehaviour
{
    public float wobbleStrength = 0.05f;

    public float rotationSpeed = 0.35f;
    
    void Update()
    {
        float t = Mathf.Sin(Time.time);
        transform.localScale += new Vector3(t * wobbleStrength, t * wobbleStrength, 0.0f);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
