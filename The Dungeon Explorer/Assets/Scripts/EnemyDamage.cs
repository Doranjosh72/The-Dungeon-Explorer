using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // CONDITION: When the projectile hits a certain object type... (enemy)
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Check if the object we collided with has the tag we are looking for (Enemy)
        if (otherCollider.CompareTag("Trap") == true)
        {
            // Perform our action
            KillEnemy(otherCollider.gameObject);
        }
    }


    // this will remove the enemy from the game
    public void KillEnemy(GameObject enemy)
    {
        Destroy(enemy);
    }
}
