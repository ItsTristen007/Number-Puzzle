using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    private int highscore = 0;
    
    [SerializeField] TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        //gets the score from the player 
        highscore = Puzzle.getScore();
    }

    // Update is called once per frame
    void Update()
    {
        //displays the score that the player got 
        scoreText.text = "You Scored: " + highscore + "/3";
    }
}
