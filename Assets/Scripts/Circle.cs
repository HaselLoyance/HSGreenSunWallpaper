using UnityEngine;

public class Circle : MonoBehaviour
{
    float sizeGrowRate = 0.0f;

	void Start ()
    {
        sizeGrowRate = Random.Range(2.0f, 3.7f);
    }
	
	void Update ()
    {
        transform.localScale += new Vector3(
            sizeGrowRate * Time.deltaTime,
            sizeGrowRate * Time.deltaTime,
            0.0f);

        if (transform.localScale.x > 20.0f)
            Destroy(gameObject);
    }
}
