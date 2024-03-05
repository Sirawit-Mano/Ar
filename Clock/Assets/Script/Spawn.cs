using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] spawnPosition;
    public GameObject clock;

    public float spawnRadius = 10f;
    public float minAngle = 0f;
    public float maxAngle = 0f;
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2);

        Vector3 randomPos = Random.insideUnitCircle * spawnRadius;


        Quaternion randomRot = Quaternion.Euler(Random.Range(minAngle, maxAngle), Random.Range(minAngle, maxAngle), Random.Range(minAngle, maxAngle));


        Instantiate(clock, transform.position + randomPos, randomRot);


        //for (int i = 0; i < 1; i++)
        //{
        //    Instantiate(clock[i], spawnPosition[i].position, Quaternion.identity);
        //}
        StartCoroutine(StartSpawning());
    }
}
