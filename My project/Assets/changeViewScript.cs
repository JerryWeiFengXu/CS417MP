using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class changeViewScript : MonoBehaviour
{
    public Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("m"))
        {
            camera.transform.position = this.transform.position + new UnityEngine.Vector3(0, 0, -8); 
        }
    }
}
