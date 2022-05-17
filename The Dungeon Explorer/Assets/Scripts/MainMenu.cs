using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // this allows the player to click on the start game button in the main menu
    public void LoadTargetScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
