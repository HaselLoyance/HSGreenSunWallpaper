using UnityEngine;

public class LightCycler : MonoBehaviour
{
    public float hueIncreaseRate = 1.0f;

    float lastHue = 0.0f;

	void Update ()
    {
        Light l = GetComponent<Light>();
        
        if (lastHue > 1.0f)
            lastHue = 0.0f;

        lastHue += hueIncreaseRate * Time.deltaTime;

        l.color = Color.HSVToRGB(lastHue, 0.85f, 1.0f);
    }
}
