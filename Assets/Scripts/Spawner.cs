using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector2 range;
    [SerializeField] private GameObject obstacle;
    [SerializeField] private GameObject points;

    private void Start()
    {
        StartCoroutine(SpawnObs());
        StartCoroutine(SpawnPoint());
    }

    private IEnumerator SpawnObs()
    {
        yield return new WaitForSeconds(1);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(obstacle, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnObs());
    }

    private IEnumerator SpawnPoint()
    {
        yield return new WaitForSeconds(1.5f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(points, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnPoint());
    }

    
}