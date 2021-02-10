using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnviromentObjects))]
public class EnviromentGenerator : MonoBehaviour
{
    private EnviromentObjects enviromentObjects;

    [SerializeField] GameObject player;

    [SerializeField] Vector2 spawnHeight;
    
    [SerializeField] float spawnDistance = 10;
    [SerializeField] float deSpawnDistance;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        enviromentObjects = GetComponent<EnviromentObjects>();
    }

    void Update()
    {
        
    }

    private GameObject GetRandomObjectFlomList(List<GameObject> gameObjects) => gameObjects[Random.Range(0, gameObjects.Count)];

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(player.transform.position, player.transform.position + Vector3.right * spawnDistance);
        Gizmos.DrawLine(player.transform.position, player.transform.position + Vector3.left * deSpawnDistance);

        Gizmos.DrawSphere(spawnHeight, .25f);
    }

}
