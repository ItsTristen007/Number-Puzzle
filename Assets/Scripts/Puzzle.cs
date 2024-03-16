using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
    [SerializeField] TMP_InputField playerInput;
    [SerializeField] TMP_Text feedback;
    [SerializeField] Button submit;
    [SerializeField] Button next;

    [SerializeField] int answer;
    
    int number;

    public static int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        playerInput.onValueChanged.AddListener(OnGuessChanged);
        submit.onClick.AddListener(OnSubmit);
        
        submit.interactable = false;
        next.interactable = false;
    }

    void OnGuessChanged(string guessString)
    {

        bool success = int.TryParse(guessString, out number);
        
        if (success && !next.interactable)
        {   
            //when player is typing in answer display this text and make submit button interactable
            feedback.text = "Is this your final answer?";
            submit.interactable = true;
        }
        else
        {   
            //if they aren't typing display this and make submit button not interactable 
            feedback.text = "Please enter a number";
            submit.interactable = false;
        }
    }

    void OnSubmit()
    {
        if (answer == number )
        {
            //if number is right display this text and add one to score 
            feedback.text = "Correct!";
            score++;
        }
        else
        {
            //if player is wrong display this text 
            feedback.text = "Incorrect!";
        }
        
        //make it so they cant submit another answer and can move onto next puzzle
        submit.interactable = false;
        next.interactable = true;
    }


    public static int getScore()
    {
        return score;
    }
    
    
}
