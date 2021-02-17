using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("References")]
    public GameObject optionsUI;
    public Options optionsScript;

    public void Options()
    {
        SceneLoader.Instance.clickSound.Play();

        optionsScript.inOptions = true;
        optionsUI.SetActive(true);
    }
}
