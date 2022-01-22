using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttoninstant : MonoBehaviour
{
    bool buttonDetect;
    public LayerMask groundMask;
    public Transform buttonCheck;
    public float buttonDistance = 0.4f;
    public GameObject platform1;
    public GameObject platform2;
    public GameObject Button;
    public float pushSpeed;
    public float highest;
    public float lowest;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        buttonDetect = Physics.CheckSphere(buttonCheck.position, buttonDistance, groundMask);
        if (buttonDetect == true)
        {
            if (count == 0)
            {
                Instantiate(platform1, new UnityEngine.Vector3(82f, 13.5f, -51.79f), transform.rotation);
                Instantiate(platform2, new UnityEngine.Vector3(82f, 13.5f, -73.76f), transform.rotation);
                count = 1;
            }
        if (buttonDetect == true && Button.transform.position.y >= lowest)
           {
                Debug.Log("cool");
                Button.transform.Translate(Vector3.down * Time.deltaTime * pushSpeed);
           }

        }
        else if (buttonDetect == false)
        {

            if (buttonDetect == false && Button.transform.position.y <= highest)
            {
                Button.transform.Translate(Vector3.up * Time.deltaTime * pushSpeed);
            }

        }
    }

}
