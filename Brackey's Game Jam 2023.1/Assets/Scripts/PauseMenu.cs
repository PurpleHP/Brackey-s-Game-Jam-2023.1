using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    [SerializeField] GameObject PlayerMovement;
    private PlayerMovement pm;
    [SerializeField] AudioSource pauseSound;
    void Start()
    {
        pauseMenu.SetActive(false);
        pm = PlayerMovement.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        if (Input.GetKeyDown(KeyCode.P) && isPaused)
        {
            Application.Quit();
            Debug.Log("Quit");
        }
    }
    public void PauseGame()
    {
        pauseSound.Play();
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        pm.enabled = false;
    }
    public void ResumeGame()
    {
        pauseSound.Play();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        pm.enabled = true;
    }
    public void QuitGame()
    {
        

    }
}
