using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    // this is a public variable.
    // public variables are editable in unity.
    //they are useable by other scripts

    public int pickupValue = 1;

    // this is called by unity when this object overlaps with another object marked as a trigger.
    // this is our condition if the player touches a flower.
    void OnTriggerEnter2D(Collider2D other)
    {
        // check if score script is attached to the thing we bump into.
        GemScore scoreScript = other.GetComponent<GemScore>();

        if (scoreScript != null)
        {
            // we have a scorescript, so the thing we bump into is the player

            // add our pickup to the player;s current score (actions)
            scoreScript.AddScore(pickupValue);

            // we should then delete this object so we don't infinietly add score
            Destroy(gameObject);
        }
    }
}
