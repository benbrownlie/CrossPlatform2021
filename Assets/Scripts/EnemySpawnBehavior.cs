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
    public GameObject Enemy;

    public float XMax;
    public float XMin;
    public float ZMax;
    public float ZMin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    public IEnumerator SpawnEnemies()
    {
        while (!StopSpawning)
        {
            float RandX = Random.Range(XMax, XMin);
            float RandZ = Random.Range(ZMax, ZMin);
            //Sets Spawn to be a new vector3 at the transforms position
            Vector3 Spawn = new Vector3(RandX, transform.position.y, RandZ);
            //Creates a new enemy
            GameObject enemy = Instantiate(Enemy.gameObject, Spawn, new Quaternion());
            //Creates a new instance of EnemyMovementBehavior
            EnemyMovementBehavior MoveEnemy = enemy.GetComponent<EnemyMovementBehavior>();
            MoveEnemy.StartCos = Random.Range(-1, 1);

            yield return new WaitForSeconds(TimeBetweenSpawns);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
