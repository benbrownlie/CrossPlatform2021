using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehavior : MonoBehaviour
{
    //Float used to set how long it'll take before another enemy spawns into the scene
    public float TimeBetweenSpawns;
    //Bool used to set if the enemies should be spawning
    public bool StopSpawning;
    //Reference to the enemy
    public GameObject EnemyTarget;
    public GameObject _spawnEnemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    public IEnumerator SpawnEnemies()
    {
        while (!StopSpawning)
        {
            GameObject spawnedEnemy = Instantiate(_spawnEnemy, transform.position, new Quaternion());

            spawnedEnemy.GetComponent<EnemyMovementBehavior>().target = EnemyTarget;

            yield return new WaitForSeconds(TimeBetweenSpawns);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
