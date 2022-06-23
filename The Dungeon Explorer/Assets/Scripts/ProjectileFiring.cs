using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFiring : MonoBehaviour
{
    // Unity editor variable
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;

    // this allows you to determine what key will be used for this function.
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            FireProjectile();
        }
    }

    // This is going to fire the projectile sprite.
    public void FireProjectile()
    {
       
        GameObject clonedProjectile;
        
        clonedProjectile = Instantiate(projectilePrefab);

      
        clonedProjectile.transform.position = transform.position; 

        
        Rigidbody2D projectileRigidbody;
        
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
       
        projectileRigidbody.velocity = projectileVelocity;

      
    }
}
