using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GemScore : MonoBehaviour
{
    // public varibles
    public Text ScoreDisplay;
    public bool shouldReset = false;
    public int winningScore;
    public string winningScene;
    // private varibles.
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




    // this adds the player score
    // this is not automatticly added by unity - we need to call it ourselfs in our code.
    public void AddScore(int toAdd)
    {
        // this will update the numerical value of the score. (this is the first action)
        scoreValue = scoreValue + toAdd;

        // this will update the display score based on the numerical value

        ScoreDisplay.text = scoreValue.ToString();

        //this will check if the score is bigger than our win score

        if (scoreValue >= winningScore)
        {
            // this will load a winning scene when you collect enough score
            SceneManager.LoadScene(winningScene);
        }

    }
}
