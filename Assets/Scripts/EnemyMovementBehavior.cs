using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementBehavior : MonoBehaviour
{
    //Reference to the enemy's target
    public GameObject target;
    //Variable used to store and adjust the enemy's speed
    public float speed;
    //
    private NavMeshAgent _agent;
    //
    public Rigidbody rigidbody;
    //
    public float StartCos;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the enemy's lookat function to be the passed in target
        transform.LookAt(target.transform);

        _agent.SetDestination(target.transform.position);
    }
}
