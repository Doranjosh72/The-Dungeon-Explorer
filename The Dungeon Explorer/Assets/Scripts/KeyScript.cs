using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{

    [SerializeField]
    GameObject Door;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == ("MainCharacter"))

        {
           
            
            
         Door.transform.position += new Vector3(0, 7, 0);


           Destroy(gameObject);
        }


    }
}
