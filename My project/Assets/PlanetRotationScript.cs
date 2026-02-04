using UnityEngine;

public class PlanetRotationScript : MonoBehaviour
{
    public SphereCollider moon; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moon = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        moon.transform.Rotate(0, 10 * Time.deltaTime, 0);
    }
}
