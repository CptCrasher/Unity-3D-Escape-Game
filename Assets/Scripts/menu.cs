using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void PlayLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("howto");
    }
    public void QuitGame()
    {
    Application.Quit();
    }   
    public void returnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
}
