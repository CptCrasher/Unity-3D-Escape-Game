using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPlatform : MonoBehaviour
{
    public LayerMask groundMask;
    public Transform winCheck;
    public float winDistance = 2f;

    bool winDetect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        winDetect = Physics.CheckSphere(winCheck.position, winDistance, groundMask);
        if(winDetect == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene("win");
        }
    }
}
