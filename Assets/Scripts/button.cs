using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    bool buttonDetect;
    public LayerMask groundMask;
    public Transform buttonCheck;
    public float buttonDistance =0.4f;
    public GameObject Door;
    public GameObject Button;
    DoorControl doorControlScript;
    public int pushSpeed = 2;
    public float highest;
    public float lowest;
    // Start is called before the first frame update
    void Start()
    {
        doorControlScript = Door.GetComponent<DoorControl>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonDetect = Physics.CheckSphere(buttonCheck.position, buttonDistance, groundMask);
        if(buttonDetect == true)
        {
            Debug.Log("Detected");
            doorControlScript.isOpening = true;
            if(buttonDetect == true && Button.transform.position.y >= lowest)
            {
                Button.transform.Translate(Vector3.down * Time.deltaTime * pushSpeed);
            }
            
        }
        else if(buttonDetect == false)
        {
            doorControlScript.isOpening = false;

        if (buttonDetect == false && Button.transform.position.y <= highest)
        {
             Button.transform.Translate(Vector3.up * Time.deltaTime * pushSpeed);
        }

        }

    }
}
