using UnityEngine;

public class lightScript : MonoBehaviour
{
    public Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
         if (Input.GetKeyDown("1"))
        {
            light.color = UnityEngine.Color.green;
        }
    }

   
}
