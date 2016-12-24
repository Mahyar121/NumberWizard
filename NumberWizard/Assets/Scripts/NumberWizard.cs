using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

   // Use this for initialization
 	int max;
 	int min;
 	int guess;
    int maxGuessesAllowed = 10;

    public Text text;
 	
 	void Start()
    {
        StartGame();

    }
 	
    public void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();
        
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
 
 	public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

 	public void NextGuess()
    {
        guess = Random.Range(min++, max++);
        text.text = guess.ToString();
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0) { SceneManager.LoadScene("Win"); }
    }

}
