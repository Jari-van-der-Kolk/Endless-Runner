using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    #region Singelton
    private static ScoreManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(this);
        }
    }
    #endregion

    public int score { get; private set; }
    public int ShowScore;
    public static ScoreManager Instance { get => instance; set => instance = value; }

    public void UpdateScore(int AddScore)
    {
        score += AddScore;
        ShowScore = score;
    }


    private void Start()
    {
        StartCoroutine(ScoreAdderOverTime(1, 0.1f));    
    }

    private IEnumerator ScoreAdderOverTime(int AddScore, float speed) 
    {
        while (true)
        {
            UpdateScore(AddScore);
            yield return new WaitForSeconds(speed);
        }

    }

}
