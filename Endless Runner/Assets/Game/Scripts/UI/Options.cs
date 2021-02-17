using UnityEngine;

public class Options : MonoBehaviour
{
    [Header("References")]
    public GameObject optionsUI;
    public PauseGame pauseGame;

    [Header("In Options Menu")]
    public bool inOptions = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (inOptions)
            {
                SceneLoader.Instance.clickSound.Play();

                inOptions = false;
                if (pauseGame != null)
                {
                    pauseGame.GoPause();
                }
                optionsUI.SetActive(false);
            }
        }
    }
}
