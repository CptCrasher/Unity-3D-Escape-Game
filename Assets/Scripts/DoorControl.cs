using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    public int openSpeed = 2;
    public GameObject Door;
    public bool isOpening;
    public bool isClosing = false;
    public float highest;
    public float lowest;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        openDoor();
    }

    void openDoor()
    {
        if (isOpening == true && Door.transform.position.y < highest)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * openSpeed);
        }
        else if(isOpening == false)
        {
            closeDoor();           
        }
    }          
    void closeDoor()
    {
        if (Door.transform.position.y > lowest)
        {
            Door.transform.Translate(Vector3.down * Time.deltaTime * openSpeed);
        }
    }

}
