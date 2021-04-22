using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackBehavior : MonoBehaviour
{
    [SerializeField]
    //How much damage the enemy will deal
    private float _damage;
    private EnemyMovementBehavior _movement;
    // Start is called before the first frame update
    
    private void Awake()
    {
        _movement = GetComponent<EnemyMovementBehavior>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //If the collided object isn't the target, return
        if (collision.gameObject != _movement.Target)
            return;

        HealthBehavior health = collision.gameObject.GetComponent<HealthBehavior>();

        if (health)
            health.TakeDamage(_damage);
    }
}
