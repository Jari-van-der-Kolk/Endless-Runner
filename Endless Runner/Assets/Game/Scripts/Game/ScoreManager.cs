using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    [SerializeField] private TextMeshProUGUI text;
    public int ShowScore;
    public static ScoreManager Instance { get => instance; set => instance = value; }

    public void UpdateScore(int AddScore)
    {
        score += AddScore;
        text.text = string.Format(score.ToString());
        ShowScore = score;
    }


    private void Start()
    {
        UpdateScore(0);
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
