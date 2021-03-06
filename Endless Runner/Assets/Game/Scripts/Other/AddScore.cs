using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] int Amount;
    private void OnDisable()
    {
        ScoreManager.Instance.UpdateScore(Amount);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioScourcer.instance.Play("coin");
            gameObject.SetActive(false);
        }
    }
}
