using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwap : MonoBehaviour
{
    public string levelToLoad;

    private void OnTriggerEnter(Collider otherCollider)
    {
        //Debug.Log("Object Hit the door");

        if (otherCollider.tag == "MainCharacter")
        {
            SceneManager.LoadScene(levelToLoad);
        }


    }
}
