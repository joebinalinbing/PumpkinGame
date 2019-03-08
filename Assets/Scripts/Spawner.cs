using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnSpoints;
    public GameObject pumpkin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning() {
        yield return new WaitForSeconds(Random.Range(1f, 3.5f));

        Instantiate(pumpkin, spawnSpoints[Random.Range(0, spawnSpoints.Length)].position, Quaternion.identity);

        StartCoroutine(StartSpawning());
    }
    



}
