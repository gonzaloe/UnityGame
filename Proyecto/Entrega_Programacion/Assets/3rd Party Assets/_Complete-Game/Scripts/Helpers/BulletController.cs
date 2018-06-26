using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CompleteProject;

public class BulletController : MonoBehaviour
{

    public int damagePerShot = 20;                  // The damage inflicted by each bullet.
    public float timeBetweenBullets = 0.15f;        // The time between each shot.
    public float range = 1000f;

    private void OnCollisionEnter(Collision collision)
    {
        EnemyHealth enemyHealth = collision.collider.GetComponent<EnemyHealth>();

        // If the EnemyHealth component exist...
        if (enemyHealth != null)
        {
            // ... the enemy should take damage.
            enemyHealth.TakeDamage(damagePerShot, collision.transform.position);
        }
        Destroy(gameObject);

    }
}
