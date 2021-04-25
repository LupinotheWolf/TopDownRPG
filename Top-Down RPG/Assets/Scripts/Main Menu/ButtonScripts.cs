using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void exitGame()
    {
        Debug.Log("Game was Exited!!");
        Application.Quit();
    }
    public void IntroScene()
    {
        SceneManager.LoadScene("Intro Scene");
    }
}
