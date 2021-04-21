using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MonoBehaviour
{
    //Reference to the enemy's target
    public GameObject target;
    //Variable used to store and adjust the enemy's speed
    public float speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Sets the enemy's lookat function to be the passed in target
        transform.LookAt(target.transform);

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        direction = (target.transform.position + target.transform.position - transform.position).normalized;
        Vector3 desiredVelocity = direction * speed;

    }
}
