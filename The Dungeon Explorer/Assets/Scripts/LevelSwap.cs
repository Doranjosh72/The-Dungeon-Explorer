using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwap : MonoBehaviour
{
    public string levelToLoad;
    // this is the player coliding with the object
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        
        // the only sprite with this tag can enter this object.
        if (otherCollider.tag == "MainCharacter")
        {
            // this will load the next level using the Scene Manager
            SceneManager.LoadScene(levelToLoad);
        }


    }
}
