using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackBehavior : MonoBehaviour
{
    [SerializeField]
    private float _damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        HealthBehavior health = collision.gameObject.GetComponent<HealthBehavior>();

        if (health)
            health.TakeDamage(_damage);
    }
}
