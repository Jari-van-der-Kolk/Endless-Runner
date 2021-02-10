using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Header("Audio Sound")]
    public AudioSource clickSound;

    private static SceneLoader instance;
    public static SceneLoader Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SceneLoader>();
            }
            return instance;
        }
    }

    public void LoadScene(int value)
    {
        StartCoroutine(LoadSceneIE(value));
    }

    IEnumerator LoadSceneIE(int value)
    {
        clickSound.Play();

        yield return new WaitForSeconds(0.1f);

        SceneManager.LoadScene(value);
    }

    public void QuitGame()
    {
        StartCoroutine(QuitGameIE());
    }

    IEnumerator QuitGameIE()
    {
        clickSound.Play();

        yield return new WaitForSeconds(0.1f);

        Application.Quit();
    }
}
