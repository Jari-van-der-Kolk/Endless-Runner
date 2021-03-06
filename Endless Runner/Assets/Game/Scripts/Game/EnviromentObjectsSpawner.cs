using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentObjectsSpawner : MonoBehaviour
{
    public FloatVariable spawnChance;
    public Placebels[] placebels;

    private void Start()
    {
        foreach (Placebels p in placebels)
        {
            int randomNumber = Random.Range(0,Mathf.RoundToInt(spawnChance.Value));
            if (randomNumber <= p.spawnIndex)
            {
                Instantiate(ReturnGameobjectFromArray(p.Objects), p.Location.transform.position, Quaternion.identity);
            }
            
        }
    }
    private GameObject ReturnGameobjectFromArray(GameObject[] objects) => objects[Random.Range(0, objects.Length)];
}

[System.Serializable]
public class Placebels
{
    public float spawnIndex;
    public Transform Location;
    public GameObject[] Objects;

}

