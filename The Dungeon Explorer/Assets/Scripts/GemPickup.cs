using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    

    public int pickupValue = 1;

    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        GemScore scoreScript = other.GetComponent<GemScore>();

        if (scoreScript != null)
        {
           
            scoreScript.AddScore(pickupValue);

            
            Destroy(gameObject);
        }
    }
}
