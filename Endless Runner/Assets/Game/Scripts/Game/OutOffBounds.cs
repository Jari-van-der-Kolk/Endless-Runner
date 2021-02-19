using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOffBounds : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public float outOfBoundsDistance;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        distance = (transform.position - player.transform.position).magnitude;
        if (distance >= outOfBoundsDistance)
        {
            Debug.Log("Game over");
        }
    }



}
