using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;

    void Start()
    {
        SpawnBall();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(SpawnRoutine());
        }
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(2);
        SpawnBall();
    }

    void SpawnBall()
    {
        Instantiate(_spawnObject, transform.position, transform.rotation);
    }
}
