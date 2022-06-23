using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayHealth : MonoBehaviour
{
    // this will be used for displaying the health
    Text healthValueDisplay;

    
    PlayersHealth player;


    
    void Start()
    {
        
        healthValueDisplay = GetComponent<Text>();

       
        player = FindObjectOfType<PlayersHealth>();
    }

    // Update is called once per frame
    void Update()
    {
       
        healthValueDisplay.text = player.GetHealth().ToString();
    }
}
