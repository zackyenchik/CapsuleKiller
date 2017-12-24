using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
	}

    IEnumerator waitSpawner ()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Vector3 SpawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 0, Random.Range(-spawnValues.z, spawnValues.z)); // Generate a random position for the enemy to spawn at
            Instantiate(enemy, SpawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation); // Create an instance of the enemy at the given position and rotation
            yield return new WaitForSeconds(spawnWait); // Generate new wait time
        }
    }
}
