using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwap : MonoBehaviour
{
    public string levelToLoad;
    // coliding with the Door object
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        
        // the sprite with the tag "MainCharacter" can be the only one to interact with the object
        if (otherCollider.tag == "MainCharacter")
        {
            // this will load the next level using the Scene Manager
            SceneManager.LoadScene(levelToLoad);
        }


    }
}
