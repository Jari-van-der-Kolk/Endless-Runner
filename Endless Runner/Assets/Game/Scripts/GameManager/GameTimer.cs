using System;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [Header("References")]
    public TMP_Text displayTimer;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        TimeSpan ts = TimeSpan.FromSeconds(timer);
        displayTimer.text = ts.ToString(@"m\:ss");
    }
}
