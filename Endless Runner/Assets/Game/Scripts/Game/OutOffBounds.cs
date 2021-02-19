using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOffBounds : MonoBehaviour
{
    public int sceneIndex;
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
            SceneManager.LoadScene(sceneIndex);
        }
    }



}
