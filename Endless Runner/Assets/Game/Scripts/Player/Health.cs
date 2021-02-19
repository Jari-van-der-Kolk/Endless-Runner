using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health Properties")]
    public float startingHealth;
    public float currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void ModifyHealth(float damage)
    {
        currentHealth -= damage;

        // clamping health
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}

