using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [Header("References")]
    public GameObject pauseUI;
    public GameObject optionsUI;
    public Options optionsScript;

    [Header("Is Game Paused")]
    public bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GoPause();
        }
    }

    public void GoPause()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        SceneLoader.Instance.clickSound.Play();

        pauseUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    void Pause()
    {
        SceneLoader.Instance.clickSound.Play();

        pauseUI.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Options()
    {
        SceneLoader.Instance.clickSound.Play();

        pauseUI.SetActive(false);
        isPaused = false;
        optionsScript.inOptions = true;
        optionsUI.SetActive(true);
    }
}
