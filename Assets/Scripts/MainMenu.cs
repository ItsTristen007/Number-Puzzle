using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    //Loading the Scene once the play button is hit 
    public void Play()
    {
        Puzzle.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Loading the Scene once the mainmenu button is hit 
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //Loading the Scene once the nextlevel button is hit 
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Retry()
    {
        //resets the score to zero then loads the first puzzle 
        Puzzle.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
}
