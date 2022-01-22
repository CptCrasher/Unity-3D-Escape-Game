using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepsound : MonoBehaviour
{
    CharacterController cc;

    bool isGrounded = false;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded == true)
        {
            Debug.Log("true");
        }
        if (isGrounded == true && cc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.4f, 0.6f);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
            GetComponent<AudioSource>().Play();

        }
    }
}
