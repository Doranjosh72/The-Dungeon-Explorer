using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField]
    GameObject Door;

    // colliding with the door
    void OnTriggerEnter2D(Collider2D col)
    {
        // the door gets relocated to a diffirent position in the game and out of the players view.
        Door.transform.position += new Vector3(0, 7, 0);


        Destroy(gameObject);
    }

    

}
