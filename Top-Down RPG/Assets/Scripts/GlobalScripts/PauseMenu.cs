using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public static bool isPaused = false;

    //Attach audio for when menu opens
    AudioSource menuOpenSound;

    private void Awake()
    {
        //Makes it so menu open sound will play, even if audiolisteners are paused
        menuOpenSound = gameObject.GetComponent<AudioSource>();
        menuOpenSound.ignoreListenerPause = true;
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (!isPaused)
            {
                PauseGame();
                isPaused = true;
            }
            else
            {
                ResumeGame();
                isPaused = false;
            }
        }
        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        menuOpenSound.Play();
        AudioListener.pause = true;
        isPaused = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        menuOpenSound.Play();
        AudioListener.pause = false;
        isPaused = false;
    }



    }
