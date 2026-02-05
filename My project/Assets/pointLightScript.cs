using UnityEngine;

public class pointLightScript : MonoBehaviour
{
    public Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l")) {
            light.color = UnityEngine.Color.green;
        }
    }
}
