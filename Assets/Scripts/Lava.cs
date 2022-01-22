using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    bool lavaDetect;
    public LayerMask groundMask;
    public Transform lavaCheck;
    public float lavaDistance = 7.5f;
    void Update()
    {

        lavaDetect = Physics.CheckBox(lavaCheck.position,new Vector3(1.89f,1f,3.73f) , Quaternion.Euler(0,0,0),groundMask);
        if (lavaDetect == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene("lose");
              
            }

        }
    }


