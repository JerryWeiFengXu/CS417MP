using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public DoorOpen door;
    public GameObject light;

    void Start()
    {
        light.GetComponent<Light>().enabled = false;
        //Debug.Log("hi" + myLight.name);
    }


    bool A_done = false;
    bool B_done = false;
    bool C_done = false;

    public void PairCompleted(string type)
    {
        if(type == "Cube") A_done = true;
        if(type == "Doll") B_done = true;
        if(type == "Chess") C_done = true;

        CheckWin();
    }

    void CheckWin()
    {
        if(A_done && B_done && C_done)
        {
            Debug.Log("YOU WIN");

            //Debug.Log("LIGHT: " + myLight.name);
            door.OpenDoor();
            light.GetComponent<Light>().enabled = true;
           

        }
    }
}

