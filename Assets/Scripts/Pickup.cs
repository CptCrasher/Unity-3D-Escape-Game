using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform onHand;
    public Transform player;
    public Transform cube;
    float distance;
    public float distanceFromHand = 1.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(cube.transform.position, player.transform.position);
        if (distance <= distanceFromHand) { 
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnEDown();
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            OnEUp();
        }
    }
    }

    void OnEDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
        this.transform.position = onHand.transform.position;
        this.transform.parent = GameObject.Find("Main Camera").transform;
    }

    void OnEUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
