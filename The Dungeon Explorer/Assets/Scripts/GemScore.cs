using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GemScore : MonoBehaviour
{
    // these are public variables.
    public Text ScoreDisplay;
    public bool shouldReset = false;
    public int winningScore;
    public string winningScene;
    // this is a private variable.
    private static int scoreValue = 0;

    // This is called by unity the frame after this object is created.
    void Start()
    {
        if (shouldReset == true)
        {
            scoreValue = 0;
        }

        ScoreDisplay.text = scoreValue.ToString();
    }




    // this functions adds the players score
    // this is not automatticly added by unity - we need to call it ourselfs in our code.
    public void AddScore(int toAdd)
    {
        // this updates the numerical value of the score. (this is the first action)
        scoreValue = scoreValue + toAdd;

        // this updates the display score based on the numerical value

        ScoreDisplay.text = scoreValue.ToString();

        //check if score is bigger than our win score

        if (scoreValue >= winningScore)
        {
            // our score is a winning score which will load the winning scene.
            SceneManager.LoadScene(winningScene);
        }

    }
}
