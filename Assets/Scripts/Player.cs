using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    /// <summary>
    /// this will store the text object in the scene
    /// </summary>
    public TextMeshProUGUI scoreText;

    public GameObject textBox; 

    /// <summary>
    /// the current score of the player
    /// </summary>
    int currentScore = 0;  

    /// <summary>
    /// Store the current collectible that the player is touching
    /// </summary>
    Collectible currentCollectible;

    /// <summary>
    /// to get the player score on the screen using the canvas text
    /// </summary>
    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        // show current score
        scoreText.text = currentScore.ToString();

        textBox.SetActive(true); //show the textbox only when collectible is collected
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
