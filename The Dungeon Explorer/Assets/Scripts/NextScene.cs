using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string levelToLoad;
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
